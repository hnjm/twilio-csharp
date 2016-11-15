using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;
using Twilio.Exceptions;

namespace Twilio.Rest.Notify.V1 
{

    public class ServiceResource : Resource 
    {
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <returns> ServiceCreator capable of executing the create </returns> 
        public static ServiceCreator Creator()
        {
            return new ServiceCreator();
        }
    
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        /// <returns> ServiceDeleter capable of executing the delete </returns> 
        public static ServiceDeleter Deleter(string sid)
        {
            return new ServiceDeleter(sid);
        }
    
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        /// <returns> ServiceFetcher capable of executing the fetch </returns> 
        public static ServiceFetcher Fetcher(string sid)
        {
            return new ServiceFetcher(sid);
        }
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <returns> ServiceReader capable of executing the read </returns> 
        public static ServiceReader Reader()
        {
            return new ServiceReader();
        }
    
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        /// <returns> ServiceUpdater capable of executing the update </returns> 
        public static ServiceUpdater Updater(string sid)
        {
            return new ServiceUpdater(sid);
        }
    
        /// <summary>
        /// Converts a JSON string into a ServiceResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ServiceResource object represented by the provided JSON </returns> 
        public static ServiceResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<ServiceResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        [JsonProperty("sid")]
        public string Sid { get; set; }
        [JsonProperty("account_sid")]
        public string AccountSid { get; set; }
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; set; }
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; set; }
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; set; }
        [JsonProperty("apn_credential_sid")]
        public string ApnCredentialSid { get; set; }
        [JsonProperty("gcm_credential_sid")]
        public string GcmCredentialSid { get; set; }
        [JsonProperty("messaging_service_sid")]
        public string MessagingServiceSid { get; set; }
        [JsonProperty("facebook_messenger_page_id")]
        public string FacebookMessengerPageId { get; set; }
        [JsonProperty("default_apn_notification_protocol_version")]
        public string DefaultApnNotificationProtocolVersion { get; set; }
        [JsonProperty("default_gcm_notification_protocol_version")]
        public string DefaultGcmNotificationProtocolVersion { get; set; }
        [JsonProperty("url")]
        public Uri Url { get; set; }
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; set; }
    
        public ServiceResource()
        {
        
        }
    
        private ServiceResource([JsonProperty("sid")]
                                string sid, 
                                [JsonProperty("account_sid")]
                                string accountSid, 
                                [JsonProperty("friendly_name")]
                                string friendlyName, 
                                [JsonProperty("date_created")]
                                string dateCreated, 
                                [JsonProperty("date_updated")]
                                string dateUpdated, 
                                [JsonProperty("apn_credential_sid")]
                                string apnCredentialSid, 
                                [JsonProperty("gcm_credential_sid")]
                                string gcmCredentialSid, 
                                [JsonProperty("messaging_service_sid")]
                                string messagingServiceSid, 
                                [JsonProperty("facebook_messenger_page_id")]
                                string facebookMessengerPageId, 
                                [JsonProperty("default_apn_notification_protocol_version")]
                                string defaultApnNotificationProtocolVersion, 
                                [JsonProperty("default_gcm_notification_protocol_version")]
                                string defaultGcmNotificationProtocolVersion, 
                                [JsonProperty("url")]
                                Uri url, 
                                [JsonProperty("links")]
                                Dictionary<string, string> links)
                                {
            Sid = sid;
            AccountSid = accountSid;
            FriendlyName = friendlyName;
            DateCreated = MarshalConverter.DateTimeFromString(dateCreated);
            DateUpdated = MarshalConverter.DateTimeFromString(dateUpdated);
            ApnCredentialSid = apnCredentialSid;
            GcmCredentialSid = gcmCredentialSid;
            MessagingServiceSid = messagingServiceSid;
            FacebookMessengerPageId = facebookMessengerPageId;
            DefaultApnNotificationProtocolVersion = defaultApnNotificationProtocolVersion;
            DefaultGcmNotificationProtocolVersion = defaultGcmNotificationProtocolVersion;
            Url = url;
            Links = links;
        }
    }
}