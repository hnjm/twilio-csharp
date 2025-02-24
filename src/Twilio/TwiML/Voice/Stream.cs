/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;
using Twilio.Types;

namespace Twilio.TwiML.Voice
{

    /// <summary>
    /// Stream TwiML Noun
    /// </summary>
    public class Stream : TwiML
    {
        public sealed class TrackEnum : StringEnum
        {
            private TrackEnum(string value) : base(value) {}
            public TrackEnum() {}
            public static implicit operator TrackEnum(string value)
            {
                return new TrackEnum(value);
            }

            public static readonly TrackEnum InboundTrack = new TrackEnum("inbound_track");
            public static readonly TrackEnum OutboundTrack = new TrackEnum("outbound_track");
            public static readonly TrackEnum BothTracks = new TrackEnum("both_tracks");
            public static readonly TrackEnum MixedTrack = new TrackEnum("mixed_track");
        }

        /// <summary>
        /// Friendly name given to the Stream
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Unique name for Stream Connector
        /// </summary>
        public string ConnectorName { get; set; }
        /// <summary>
        /// URL of the remote service where the Stream is routed
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// Track to be streamed to remote service
        /// </summary>
        public Stream.TrackEnum Track { get; set; }

        /// <summary>
        /// Create a new Stream
        /// </summary>
        /// <param name="name"> Friendly name given to the Stream </param>
        /// <param name="connectorName"> Unique name for Stream Connector </param>
        /// <param name="url"> URL of the remote service where the Stream is routed </param>
        /// <param name="track"> Track to be streamed to remote service </param>
        public Stream(string name = null,
                      string connectorName = null,
                      string url = null,
                      Stream.TrackEnum track = null) : base("Stream")
        {
            this.Name = name;
            this.ConnectorName = connectorName;
            this.Url = url;
            this.Track = track;
        }

        /// <summary>
        /// Return the attributes of the TwiML tag
        /// </summary>
        protected override List<XAttribute> GetElementAttributes()
        {
            var attributes = new List<XAttribute>();
            if (this.Name != null)
            {
                attributes.Add(new XAttribute("name", this.Name));
            }
            if (this.ConnectorName != null)
            {
                attributes.Add(new XAttribute("connectorName", this.ConnectorName));
            }
            if (this.Url != null)
            {
                attributes.Add(new XAttribute("url", this.Url));
            }
            if (this.Track != null)
            {
                attributes.Add(new XAttribute("track", this.Track.ToString()));
            }
            return attributes;
        }

        /// <summary>
        /// Create a new <Parameter/> element and append it as a child of this element.
        /// </summary>
        /// <param name="name"> The name of the custom parameter </param>
        /// <param name="value"> The value of the custom parameter </param>
        public Stream Parameter(string name = null, string value = null)
        {
            var newChild = new Parameter(name, value);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Parameter/> element as a child of this element
        /// </summary>
        /// <param name="parameter"> A Parameter instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public Stream Parameter(Parameter parameter)
        {
            this.Append(parameter);
            return this;
        }

        /// <summary>
        /// Append a child TwiML element to this element returning this element to allow chaining.
        /// </summary>
        /// <param name="childElem"> Child TwiML element to add </param>
        public new Stream Append(TwiML childElem)
        {
            return (Stream) base.Append(childElem);
        }

        /// <summary>
        /// Add freeform key-value attributes to the generated xml
        /// </summary>
        /// <param name="key"> Option key </param>
        /// <param name="value"> Option value </param>
        public new Stream SetOption(string key, object value)
        {
            return (Stream) base.SetOption(key, value);
        }
    }

}