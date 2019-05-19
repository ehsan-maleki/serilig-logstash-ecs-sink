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
using Serilog.Configuration;
using Serilog.Events;
using Serilog.Sinks.HttpLogstashEcs;

namespace Serilog
{
    /// <summary>
    ///     Adds the WriteTo.LogstashHttp() extension method to <see cref="LoggerConfiguration" />.
    /// </summary>
    public static class LoggerConfigurationHttpLogstashEcsExtensions
    {
        /// <summary>
        ///     Adds a sink that writes log events as documents to Logstash http plugin.
        /// </summary>
        /// <param name="loggerSinkConfiguration">Options for the sink.</param>
        /// <param name="options">Provides options specific to the LogstashHttp sink</param>
        /// <returns>LoggerConfiguration object</returns>
        public static LoggerConfiguration HttpLogstashEcs(
            this LoggerSinkConfiguration loggerSinkConfiguration,
            HttpLogstashEcsSinkOptions options)
        {
            var sink = new HttpLogstashEcsSink(options);

            return loggerSinkConfiguration.Sink(sink, options.MinimumLogEventLevel ?? LevelAlias.Minimum);
        }

        /// <summary>
        ///     Overload to allow basic configuration through AppSettings.
        /// </summary>
        /// <param name="loggerSinkConfiguration">Options for the sink.</param>
        /// <param name="logstashUri">URI for Logstash.</param>
        /// <returns>LoggerConfiguration object</returns>
        /// <exception cref="ArgumentNullException"><paramref name="logstashUri" /> is <see langword="null" />.</exception>
        public static LoggerConfiguration HttpLogstashEcs(
            this LoggerSinkConfiguration loggerSinkConfiguration,
            string logstashUri)
        {
            if (string.IsNullOrEmpty(logstashUri))
                throw new ArgumentNullException(nameof(logstashUri), "No Logstash uri specified.");

            var options = new HttpLogstashEcsSinkOptions
            {
                LogstashUri = logstashUri
            };

            return HttpLogstashEcs(loggerSinkConfiguration, options);
        }
    }
}