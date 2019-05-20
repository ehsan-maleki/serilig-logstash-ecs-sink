// MIT License
//
// Copyright (c) 2019 Ehsan Maleki Zoeram (ehsan.maleki@gmail.com)
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Nito.AsyncEx;
using Serilog.ElasticCommonSchema;
using Serilog.Events;
using Serilog.Sinks.PeriodicBatching;

namespace Serilog.Sinks.HttpLogstashEcs
{
    public class HttpLogstashEcsSink : PeriodicBatchingSink
    {
        private static readonly HttpClient HttpClient = new HttpClient();
        private static readonly AsyncLock Mutex = new AsyncLock();

        private readonly HttpLogstashEcsSinkState _state;

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpLogstashEcsSink"/> class with the provided options
        /// </summary>
        /// <param name="options">
        /// Options configuring how the sink behaves, may NOT be null
        /// </param>
        public HttpLogstashEcsSink(HttpLogstashEcsSinkOptions options)
            : base(options.BatchPostingLimit, options.Period)
        {
            _state = HttpLogstashEcsSinkState.Create(options);
        }

        /// <summary>
        /// Emit a batch of log events, running to completion synchronously.
        /// </summary>
        /// <param name="events">
        /// The events to emit.
        /// </param>
        /// <remarks>
        /// Override either
        ///     <see cref="M:Serilog.Sinks.PeriodicBatching.PeriodicBatchingSink.EmitBatch(System.Collections.Generic.IEnumerable{Serilog.Events.LogEvent})"/>
        ///     or
        ///     <see cref="M:Serilog.Sinks.PeriodicBatching.PeriodicBatchingSink.EmitBatchAsync(System.Collections.Generic.IEnumerable{Serilog.Events.LogEvent})"/>
        ///     , not both.
        /// </remarks>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        protected override async Task EmitBatchAsync(IEnumerable<LogEvent> events)
        {
            // ReSharper disable PossibleMultipleEnumeration
            if (events == null || !events.Any()) return;

            foreach (var e in events)
            {
                try
                {
                    BaseModel model;
                    if (e.Exception != null)
                    {
                        model = new BaseModel(e.Exception);
                        model.Timestamp = e.Timestamp;
                    }
                    else
                    {
                        model = new BaseModel();
                    }
                    
                    /*var sw = new StringWriter();
                    _state.Formatter.Format(e, sw);
                    var logData = sw.ToString();*/

                    var logData = JsonConvert.SerializeObject(model);                    
                    var stringContent = new StringContent(logData);
                    stringContent.Headers.Remove("Content-Type");
                    stringContent.Headers.Add("Content-Type", "application/json");

                    // Using singleton of HttpClient so we need ensure of thread safety. Just use LockAsync.
                    using (await Mutex.LockAsync().ConfigureAwait(false))
                    {
                        await HttpClient.PostAsync(_state.Options.LogstashUri, stringContent).ConfigureAwait(false);
                    }
                }
                catch (Exception ex)
                {
                    // Debug me
                    throw ex;
                }
            }
        }
    }
}