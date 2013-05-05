namespace Google.Apis.Analytics.v3
{
    public partial class AnalyticsService : Google.Apis.Services.BaseClientService
    {

        public const string Version = "v3";

        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        private System.Collections.Generic.IDictionary<string, Google.Apis.Discovery.IParameter> _serviceParameters;

        public AnalyticsService(Google.Apis.Services.BaseClientService.Initializer initializer) :
            base(initializer)
        {
            this._management = new ManagementResource(this, Authenticator);
            this._data = new DataResource(this, Authenticator);
            this.InitParameters();
        }

        public AnalyticsService() :
            this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        public override System.Collections.Generic.IList<string> Features
        {
            get
            {
                return new string[0];
            }
        }

        public override string Name
        {
            get
            {
                return "analytics";
            }
        }

        public override string BaseUri
        {
            get
            {
                return "https://www.googleapis.com/analytics/v3/";
            }
        }

        public override System.Collections.Generic.IDictionary<string, Google.Apis.Discovery.IParameter> ServiceParameters
        {
            get
            {
                return this._serviceParameters;
            }
        }

        public override Google.Apis.Requests.IRequest CreateRequest(Google.Apis.Requests.IClientServiceRequest serviceRequest)
        {
            Google.Apis.Requests.IRequest request = Google.Apis.Requests.Request.CreateRequest(this, serviceRequest);
            if ((string.IsNullOrEmpty(ApiKey) == false))
            {
                request = request.WithKey(this.ApiKey);
            }
            return request.WithAuthentication(Authenticator);
        }

        private void InitParameters()
        {
            System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter> parameters = new System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter>();
            parameters.Add("prettyPrint", Google.Apis.Util.Utilities.CreateRuntimeParameter("prettyPrint", false, "query", "false", null, new string[0]));
            parameters.Add("fields", Google.Apis.Util.Utilities.CreateRuntimeParameter("fields", false, "query", null, null, new string[0]));
            parameters.Add("quotaUser", Google.Apis.Util.Utilities.CreateRuntimeParameter("quotaUser", false, "query", null, null, new string[0]));
            parameters.Add("oauth_token", Google.Apis.Util.Utilities.CreateRuntimeParameter("oauth_token", false, "query", null, null, new string[0]));
            parameters.Add("key", Google.Apis.Util.Utilities.CreateRuntimeParameter("key", false, "query", null, null, new string[0]));
            parameters.Add("userIp", Google.Apis.Util.Utilities.CreateRuntimeParameter("userIp", false, "query", null, null, new string[0]));
            parameters.Add("alt", Google.Apis.Util.Utilities.CreateRuntimeParameter("alt", false, "query", "json", null, new string[] {
                            "json"}));
            this._serviceParameters = new Google.Apis.Util.ReadOnlyDictionary<string, Google.Apis.Discovery.IParameter>(parameters);
        }

        /// <summary>A list of all OAuth2.0 scopes. Each of these scopes relates to a permission or group of permissions that different methods of this API may need.</summary>
        public enum Scopes
        {

            /// <summary>View and manage your Google Analytics data</summary>
            [Google.Apis.Util.StringValueAttribute("https://www.googleapis.com/auth/analytics")]
            Analytics,

            /// <summary>View your Google Analytics data</summary>
            [Google.Apis.Util.StringValueAttribute("https://www.googleapis.com/auth/analytics.readonly")]
            AnalyticsReadonly,
        }
    }

}
