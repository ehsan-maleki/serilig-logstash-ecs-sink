using System;
using Serilog.Events;
using Serilog.Formatting;

namespace Serilog.Sinks.HttpLogstashEcs
{
    /// <summary>
    ///     Provides ElasticsearchSink with configurable options
    /// </summary>
    public class HttpLogstashEcsSinkOptions
    {
        /// <summary>
        ///     Configures the sink defaults
        /// </summary>
        public HttpLogstashEcsSinkOptions()
        {
            Period = TimeSpan.FromSeconds(2);
            BatchPostingLimit = 50;
        }

        /// <summary>
        ///     The maximum number of events to post in a single batch.
        /// </summary>
        public int BatchPostingLimit { get; set; }

        /// <summary>
        ///     The time to wait between checking for event batches. Defaults to 2 seconds.
        /// </summary>
        public TimeSpan Period { get; set; }

        /// <summary>
        ///     Supplies culture-specific formatting information, or null.
        /// </summary>
        public IFormatProvider FormatProvider { get; set; }

        /// <summary>
        ///     When true fields will be written at the root of the json document
        /// </summary>
        public bool InlineFields { get; set; }

        /// <summary>
        ///     The minimum log event level required in order to write an event to the sink.
        /// </summary>
        public LogEventLevel? MinimumLogEventLevel { get; set; }

        /// <summary>
        ///     Customizes the formatter used when converting log events into ElasticSearch documents. Please note that the
        ///     formatter output must be valid JSON
        /// </summary>
        public ITextFormatter CustomFormatter { get; set; }

        /// <summary>
        ///     Customizes the formatter used when converting log events into the durable sink. Please note that the formatter
        ///     output must be valid JSON
        /// </summary>
        public ITextFormatter CustomDurableFormatter { get; set; }

        /// <summary>
        ///     Logstash Uri
        /// </summary>
        public string LogstashUri { get; set; }
    }
}