/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
///
/// ConversationResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Conversations.V1
{

    public class ConversationResource : Resource
    {
        public sealed class WebhookEnabledTypeEnum : StringEnum
        {
            private WebhookEnabledTypeEnum(string value) : base(value) {}
            public WebhookEnabledTypeEnum() {}
            public static implicit operator WebhookEnabledTypeEnum(string value)
            {
                return new WebhookEnabledTypeEnum(value);
            }

            public static readonly WebhookEnabledTypeEnum True = new WebhookEnabledTypeEnum("true");
            public static readonly WebhookEnabledTypeEnum False = new WebhookEnabledTypeEnum("false");
        }

        private static Request BuildCreateRequest(CreateConversationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Conversations,
                "/v1/Conversations",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Conversation parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Conversation </returns>
        public static ConversationResource Create(CreateConversationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Conversation parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Conversation </returns>
        public static async System.Threading.Tasks.Task<ConversationResource> CreateAsync(CreateConversationOptions options,
                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// create
        /// </summary>
        /// <param name="friendlyName"> The human-readable name of this conversation. </param>
        /// <param name="dateCreated"> The date that this resource was created. </param>
        /// <param name="dateUpdated"> The date that this resource was last updated. </param>
        /// <param name="messagingServiceSid"> The unique id of the SMS Service this conversation belongs to. </param>
        /// <param name="attributes"> An optional string metadata field you can use to store any data you wish. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Conversation </returns>
        public static ConversationResource Create(string friendlyName = null,
                                                  DateTime? dateCreated = null,
                                                  DateTime? dateUpdated = null,
                                                  string messagingServiceSid = null,
                                                  string attributes = null,
                                                  ITwilioRestClient client = null)
        {
            var options = new CreateConversationOptions(){FriendlyName = friendlyName, DateCreated = dateCreated, DateUpdated = dateUpdated, MessagingServiceSid = messagingServiceSid, Attributes = attributes};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="friendlyName"> The human-readable name of this conversation. </param>
        /// <param name="dateCreated"> The date that this resource was created. </param>
        /// <param name="dateUpdated"> The date that this resource was last updated. </param>
        /// <param name="messagingServiceSid"> The unique id of the SMS Service this conversation belongs to. </param>
        /// <param name="attributes"> An optional string metadata field you can use to store any data you wish. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Conversation </returns>
        public static async System.Threading.Tasks.Task<ConversationResource> CreateAsync(string friendlyName = null,
                                                                                          DateTime? dateCreated = null,
                                                                                          DateTime? dateUpdated = null,
                                                                                          string messagingServiceSid = null,
                                                                                          string attributes = null,
                                                                                          ITwilioRestClient client = null)
        {
            var options = new CreateConversationOptions(){FriendlyName = friendlyName, DateCreated = dateCreated, DateUpdated = dateUpdated, MessagingServiceSid = messagingServiceSid, Attributes = attributes};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateConversationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Conversations,
                "/v1/Conversations/" + options.PathSid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update Conversation parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Conversation </returns>
        public static ConversationResource Update(UpdateConversationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update Conversation parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Conversation </returns>
        public static async System.Threading.Tasks.Task<ConversationResource> UpdateAsync(UpdateConversationOptions options,
                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        /// <param name="friendlyName"> The human-readable name of this conversation. </param>
        /// <param name="dateCreated"> The date that this resource was created. </param>
        /// <param name="dateUpdated"> The date that this resource was last updated. </param>
        /// <param name="attributes"> An optional string metadata field you can use to store any data you wish. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Conversation </returns>
        public static ConversationResource Update(string pathSid,
                                                  string friendlyName = null,
                                                  DateTime? dateCreated = null,
                                                  DateTime? dateUpdated = null,
                                                  string attributes = null,
                                                  ITwilioRestClient client = null)
        {
            var options = new UpdateConversationOptions(pathSid){FriendlyName = friendlyName, DateCreated = dateCreated, DateUpdated = dateUpdated, Attributes = attributes};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        /// <param name="friendlyName"> The human-readable name of this conversation. </param>
        /// <param name="dateCreated"> The date that this resource was created. </param>
        /// <param name="dateUpdated"> The date that this resource was last updated. </param>
        /// <param name="attributes"> An optional string metadata field you can use to store any data you wish. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Conversation </returns>
        public static async System.Threading.Tasks.Task<ConversationResource> UpdateAsync(string pathSid,
                                                                                          string friendlyName = null,
                                                                                          DateTime? dateCreated = null,
                                                                                          DateTime? dateUpdated = null,
                                                                                          string attributes = null,
                                                                                          ITwilioRestClient client = null)
        {
            var options = new UpdateConversationOptions(pathSid){FriendlyName = friendlyName, DateCreated = dateCreated, DateUpdated = dateUpdated, Attributes = attributes};
            return await UpdateAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteConversationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Conversations,
                "/v1/Conversations/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete Conversation parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Conversation </returns>
        public static bool Delete(DeleteConversationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete Conversation parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Conversation </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteConversationOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Conversation </returns>
        public static bool Delete(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteConversationOptions(pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Conversation </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteConversationOptions(pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        private static Request BuildFetchRequest(FetchConversationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Conversations,
                "/v1/Conversations/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Conversation parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Conversation </returns>
        public static ConversationResource Fetch(FetchConversationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Conversation parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Conversation </returns>
        public static async System.Threading.Tasks.Task<ConversationResource> FetchAsync(FetchConversationOptions options,
                                                                                         ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Conversation </returns>
        public static ConversationResource Fetch(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchConversationOptions(pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Conversation </returns>
        public static async System.Threading.Tasks.Task<ConversationResource> FetchAsync(string pathSid,
                                                                                         ITwilioRestClient client = null)
        {
            var options = new FetchConversationOptions(pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadConversationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Conversations,
                "/v1/Conversations",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Conversation parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Conversation </returns>
        public static ResourceSet<ConversationResource> Read(ReadConversationOptions options,
                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<ConversationResource>.FromJson("conversations", response.Content);
            return new ResourceSet<ConversationResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Conversation parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Conversation </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<ConversationResource>> ReadAsync(ReadConversationOptions options,
                                                                                                     ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<ConversationResource>.FromJson("conversations", response.Content);
            return new ResourceSet<ConversationResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Conversation </returns>
        public static ResourceSet<ConversationResource> Read(int? pageSize = null,
                                                             long? limit = null,
                                                             ITwilioRestClient client = null)
        {
            var options = new ReadConversationOptions(){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Conversation </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<ConversationResource>> ReadAsync(int? pageSize = null,
                                                                                                     long? limit = null,
                                                                                                     ITwilioRestClient client = null)
        {
            var options = new ReadConversationOptions(){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<ConversationResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<ConversationResource>.FromJson("conversations", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<ConversationResource> NextPage(Page<ConversationResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Conversations,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<ConversationResource>.FromJson("conversations", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<ConversationResource> PreviousPage(Page<ConversationResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Conversations,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<ConversationResource>.FromJson("conversations", response.Content);
        }

        /// <summary>
        /// Converts a JSON string into a ConversationResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ConversationResource object represented by the provided JSON </returns>
        public static ConversationResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<ConversationResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The unique id of the Account responsible for this conversation.
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The unique id of the Chat Service this conversation belongs to.
        /// </summary>
        [JsonProperty("chat_service_sid")]
        public string ChatServiceSid { get; private set; }
        /// <summary>
        /// The unique id of the SMS Service this conversation belongs to.
        /// </summary>
        [JsonProperty("messaging_service_sid")]
        public string MessagingServiceSid { get; private set; }
        /// <summary>
        /// A 34 character string that uniquely identifies this resource.
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The human-readable name of this conversation.
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// An optional string metadata field you can use to store any data you wish.
        /// </summary>
        [JsonProperty("attributes")]
        public string Attributes { get; private set; }
        /// <summary>
        /// The date that this resource was created.
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date that this resource was last updated.
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// An absolute URL for this conversation.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// Absolute URLs to access the Participants of this Conversation.
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        private ConversationResource()
        {

        }
    }

}