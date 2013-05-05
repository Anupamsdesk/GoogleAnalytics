using Google.Apis.Analytics.v3.Data;
namespace Google.Apis.Analytics.v3
{
    public class DataResource 
    {

        private AnalyticsService service;

        private Google.Apis.Authentication.IAuthenticator authenticator;

        private const string Resource = "data";

        private McfResource _mcf;

        private GaResource _ga;

        public DataResource(AnalyticsService service, Google.Apis.Authentication.IAuthenticator authenticator)
        {
            this.service = service;
            this.authenticator = authenticator;
            this._mcf = new McfResource(service, authenticator);
            this._ga = new GaResource(service, authenticator);
        }

        public virtual McfResource Mcf
        {
            get
            {
                return this._mcf;
            }
        }

        public virtual GaResource Ga
        {
            get
            {
                return this._ga;
            }
        }

        public class McfResource
        {

            private AnalyticsService service;

            private Google.Apis.Authentication.IAuthenticator authenticator;

            private const string Resource = "data.mcf";

            public McfResource(AnalyticsService service, Google.Apis.Authentication.IAuthenticator authenticator)
            {
                this.service = service;
                this.authenticator = authenticator;
            }

            /// <summary>Returns Analytics Multi-Channel Funnels data for a profile.</summary>
            /// <param name="ids">Required - Must match pattern ga:[0-9]+ - Unique table ID for retrieving Analytics data. Table ID is of the form ga:XXXX, where XXXX is the Analytics profile ID.</param>
            /// <param name="startDate">start-date - Required - Must match pattern [0-9]{4}-[0-9]{2}-[0-9]{2} - Start date for fetching Analytics data. All requests should specify a start date formatted as YYYY-MM-DD.</param>
            /// <param name="endDate">end-date - Required - Must match pattern [0-9]{4}-[0-9]{2}-[0-9]{2} - End date for fetching Analytics data. All requests should specify an end date formatted as YYYY-MM-DD.</param>
            /// <param name="metrics">Required - Must match pattern mcf:.+ - A comma-separated list of Multi-Channel Funnels metrics. E.g., &apos;mcf:totalConversions,mcf:totalConversionValue&apos;. At least one metric must be specified.</param>
            public virtual GetRequest Get(string ids, string startDate, string endDate, string metrics)
            {
                return new GetRequest(service, ids, startDate, endDate, metrics);
            }

            public class GetRequest : Google.Apis.Requests.ClientServiceRequest<Google.Apis.Analytics.v3.Data.McfData>
            {

                private System.Nullable<bool> _prettyPrint;

                private string _fields;

                private string _quotaUser;

                private string _oauth_token;

                private string _userIp;

                private string _alt;

                private System.Nullable<long> _maxResults;

                private string _sort;

                private string _dimensions;

                private string _startDate;

                private System.Nullable<long> _startIndex;

                private string _ids;

                private string _metrics;

                private string _filters;

                private string _endDate;

                public GetRequest(Google.Apis.Services.IClientService service, string ids, string startDate, string endDate, string metrics) :
                    base(service)
                {
                    this._ids = ids;
                    this._startDate = startDate;
                    this._endDate = endDate;
                    this._metrics = metrics;
                    this.InitParameters();
                }

                /// <summary>Returns response with indentations and line breaks.</summary>
                [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> PrettyPrint
                {
                    get
                    {
                        return this._prettyPrint;
                    }
                    set
                    {
                        this._prettyPrint = value;
                    }
                }

                /// <summary>Selector specifying which fields to include in a partial response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Fields
                {
                    get
                    {
                        return this._fields;
                    }
                    set
                    {
                        this._fields = value;
                    }
                }

                /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided.</summary>
                [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string QuotaUser
                {
                    get
                    {
                        return this._quotaUser;
                    }
                    set
                    {
                        this._quotaUser = value;
                    }
                }

                /// <summary>OAuth 2.0 token for the current user.</summary>
                [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Oauth_token
                {
                    get
                    {
                        return this._oauth_token;
                    }
                    set
                    {
                        this._oauth_token = value;
                    }
                }

                /// <summary>IP address of the site where the request originates. Use this if you want to enforce per-user limits.</summary>
                [Google.Apis.Util.RequestParameterAttribute("userIp", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UserIp
                {
                    get
                    {
                        return this._userIp;
                    }
                    set
                    {
                        this._userIp = value;
                    }
                }

                /// <summary>Data format for the response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Alt
                {
                    get
                    {
                        return this._alt;
                    }
                    set
                    {
                        this._alt = value;
                    }
                }

                /// <summary>The maximum number of entries to include in this feed.</summary>
                [Google.Apis.Util.RequestParameterAttribute("max-results", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> MaxResults
                {
                    get
                    {
                        return this._maxResults;
                    }
                    set
                    {
                        this._maxResults = value;
                    }
                }

                /// <summary>A comma-separated list of dimensions or metrics that determine the sort order for the Analytics data.</summary>
                [Google.Apis.Util.RequestParameterAttribute("sort", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Sort
                {
                    get
                    {
                        return this._sort;
                    }
                    set
                    {
                        this._sort = value;
                    }
                }

                /// <summary>A comma-separated list of Multi-Channel Funnels dimensions. E.g., 'mcf:source,mcf:medium'.</summary>
                [Google.Apis.Util.RequestParameterAttribute("dimensions", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Dimensions
                {
                    get
                    {
                        return this._dimensions;
                    }
                    set
                    {
                        this._dimensions = value;
                    }
                }

                /// <summary>Start date for fetching Analytics data. All requests should specify a start date formatted as YYYY-MM-DD.</summary>
                [Google.Apis.Util.RequestParameterAttribute("start-date", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string StartDate
                {
                    get
                    {
                        return this._startDate;
                    }
                }

                /// <summary>An index of the first entity to retrieve. Use this parameter as a pagination mechanism along with the max-results parameter.</summary>
                [Google.Apis.Util.RequestParameterAttribute("start-index", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> StartIndex
                {
                    get
                    {
                        return this._startIndex;
                    }
                    set
                    {
                        this._startIndex = value;
                    }
                }

                /// <summary>Unique table ID for retrieving Analytics data. Table ID is of the form ga:XXXX, where XXXX is the Analytics profile ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("ids", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Ids
                {
                    get
                    {
                        return this._ids;
                    }
                }

                /// <summary>A comma-separated list of Multi-Channel Funnels metrics. E.g., 'mcf:totalConversions,mcf:totalConversionValue'. At least one metric must be specified.</summary>
                [Google.Apis.Util.RequestParameterAttribute("metrics", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Metrics
                {
                    get
                    {
                        return this._metrics;
                    }
                }

                /// <summary>A comma-separated list of dimension or metric filters to be applied to the Analytics data.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filters", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filters
                {
                    get
                    {
                        return this._filters;
                    }
                    set
                    {
                        this._filters = value;
                    }
                }

                /// <summary>End date for fetching Analytics data. All requests should specify an end date formatted as YYYY-MM-DD.</summary>
                [Google.Apis.Util.RequestParameterAttribute("end-date", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string EndDate
                {
                    get
                    {
                        return this._endDate;
                    }
                }

                public override string ResourcePath
                {
                    get
                    {
                        return "data.mcf";
                    }
                }

                public override string MethodName
                {
                    get
                    {
                        return "get";
                    }
                }

                public override string HttpMethod
                {
                    get
                    {
                        return "GET";
                    }
                }

                public override string RestPath
                {
                    get
                    {
                        return "data/mcf";
                    }
                }

                private void InitParameters()
                {
                    System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter> parameters = new System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter>();
                    parameters.Add("max-results", Google.Apis.Util.Utilities.CreateRuntimeParameter("max-results", false, "query", null, null, new string[0]));
                    parameters.Add("sort", Google.Apis.Util.Utilities.CreateRuntimeParameter("sort", false, "query", null, "(-)?mcf:.+", new string[0]));
                    parameters.Add("dimensions", Google.Apis.Util.Utilities.CreateRuntimeParameter("dimensions", false, "query", null, "(mcf:.+)?", new string[0]));
                    parameters.Add("start-date", Google.Apis.Util.Utilities.CreateRuntimeParameter("start-date", true, "query", null, "[0-9]{4}-[0-9]{2}-[0-9]{2}", new string[0]));
                    parameters.Add("start-index", Google.Apis.Util.Utilities.CreateRuntimeParameter("start-index", false, "query", null, null, new string[0]));
                    parameters.Add("ids", Google.Apis.Util.Utilities.CreateRuntimeParameter("ids", true, "query", null, "ga:[0-9]+", new string[0]));
                    parameters.Add("metrics", Google.Apis.Util.Utilities.CreateRuntimeParameter("metrics", true, "query", null, "mcf:.+", new string[0]));
                    parameters.Add("filters", Google.Apis.Util.Utilities.CreateRuntimeParameter("filters", false, "query", null, "mcf:.+", new string[0]));
                    parameters.Add("end-date", Google.Apis.Util.Utilities.CreateRuntimeParameter("end-date", true, "query", null, "[0-9]{4}-[0-9]{2}-[0-9]{2}", new string[0]));
                    this._requestParameters = new Google.Apis.Util.ReadOnlyDictionary<string, Google.Apis.Discovery.IParameter>(parameters);
                }
            }
        }

        public class GaResource
        {

            private AnalyticsService service;

            private Google.Apis.Authentication.IAuthenticator authenticator;

            private const string Resource = "data.ga";

            public GaResource(AnalyticsService service, Google.Apis.Authentication.IAuthenticator authenticator)
            {
                this.service = service;
                this.authenticator = authenticator;
            }

            /// <summary>Returns Analytics data for a profile.</summary>
            /// <param name="ids">Required - Must match pattern ga:[0-9]+ - Unique table ID for retrieving Analytics data. Table ID is of the form ga:XXXX, where XXXX is the Analytics profile ID.</param>
            /// <param name="startDate">start-date - Required - Must match pattern [0-9]{4}-[0-9]{2}-[0-9]{2} - Start date for fetching Analytics data. All requests should specify a start date formatted as YYYY-MM-DD.</param>
            /// <param name="endDate">end-date - Required - Must match pattern [0-9]{4}-[0-9]{2}-[0-9]{2} - End date for fetching Analytics data. All requests should specify an end date formatted as YYYY-MM-DD.</param>
            /// <param name="metrics">Required - Must match pattern ga:.+ - A comma-separated list of Analytics metrics. E.g., &apos;ga:visits,ga:pageviews&apos;. At least one metric must be specified.</param>
            /// <param name="dimensions">Optional - Must match pattern ga:.+ - A comma-separated list of Analytics metrics. E.g., &apos;ga:browser&apos;. At least one metric must be specified.</param>
            public virtual GetRequest Get(string ids, string startDate, string endDate, string metrics, string dimensions = null,
                string sort = null, string filters = null, int start_index = 0, int max_results = 0)
            {
                return new GetRequest(service, ids, startDate, endDate, metrics, dimensions, sort, filters, start_index, max_results);
            }

            public class GetRequest : Google.Apis.Requests.ClientServiceRequest<Google.Apis.Analytics.v3.Data.GaData>
            {

                private System.Nullable<bool> _prettyPrint;

                private string _fields;

                private string _quotaUser;

                private string _oauth_token;

                private string _userIp;

                private string _alt;

                private System.Nullable<long> _maxResults;

                private string _sort;

                private string _dimensions;

                private string _startDate;

                private System.Nullable<long> _startIndex;

                private string _segment;

                private string _ids;

                private string _metrics;

                private string _filters;

                private string _endDate;

                public GetRequest(Google.Apis.Services.IClientService service, string ids, string startDate, string endDate,
                    string metrics, string dimensions = null, string sort = null, string filters = null, int start_index = 0,
                    int max_results = 0) :
                    base(service)
                {
                    this._ids = ids;
                    this._startDate = startDate;
                    this._endDate = endDate;
                    this._metrics = metrics;
                    if (dimensions != null) this._dimensions = dimensions;
                    if (sort != null) this._sort = sort;
                    if (filters != null) this._filters = filters;
                    if (start_index != 0) this._startIndex = start_index;
                    if (max_results != 0) this._maxResults = max_results;
                    this.InitParameters();

                    this.Fetch();
                }

                public virtual GaData FetchSync(){
                    return this.Fetch();
                }

                /// <summary>Returns response with indentations and line breaks.</summary>
                [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> PrettyPrint
                {
                    get
                    {
                        return this._prettyPrint;
                    }
                    set
                    {
                        this._prettyPrint = value;
                    }
                }

                /// <summary>Selector specifying which fields to include in a partial response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Fields
                {
                    get
                    {
                        return this._fields;
                    }
                    set
                    {
                        this._fields = value;
                    }
                }

                /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided.</summary>
                [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string QuotaUser
                {
                    get
                    {
                        return this._quotaUser;
                    }
                    set
                    {
                        this._quotaUser = value;
                    }
                }

                /// <summary>OAuth 2.0 token for the current user.</summary>
                [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Oauth_token
                {
                    get
                    {
                        return this._oauth_token;
                    }
                    set
                    {
                        this._oauth_token = value;
                    }
                }

                /// <summary>IP address of the site where the request originates. Use this if you want to enforce per-user limits.</summary>
                [Google.Apis.Util.RequestParameterAttribute("userIp", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UserIp
                {
                    get
                    {
                        return this._userIp;
                    }
                    set
                    {
                        this._userIp = value;
                    }
                }

                /// <summary>Data format for the response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Alt
                {
                    get
                    {
                        return this._alt;
                    }
                    set
                    {
                        this._alt = value;
                    }
                }

                /// <summary>The maximum number of entries to include in this feed.</summary>
                [Google.Apis.Util.RequestParameterAttribute("max-results", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> MaxResults
                {
                    get
                    {
                        return this._maxResults;
                    }
                    set
                    {
                        this._maxResults = value;
                    }
                }

                /// <summary>A comma-separated list of dimensions or metrics that determine the sort order for Analytics data.</summary>
                [Google.Apis.Util.RequestParameterAttribute("sort", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Sort
                {
                    get
                    {
                        return this._sort;
                    }
                    set
                    {
                        this._sort = value;
                    }
                }

                /// <summary>A comma-separated list of Analytics dimensions. E.g., 'ga:browser,ga:city'.</summary>
                [Google.Apis.Util.RequestParameterAttribute("dimensions", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Dimensions
                {
                    get
                    {
                        return this._dimensions;
                    }
                    set
                    {
                        this._dimensions = value;
                    }
                }

                /// <summary>Start date for fetching Analytics data. All requests should specify a start date formatted as YYYY-MM-DD.</summary>
                [Google.Apis.Util.RequestParameterAttribute("start-date", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string StartDate
                {
                    get
                    {
                        return this._startDate;
                    }
                }

                /// <summary>An index of the first entity to retrieve. Use this parameter as a pagination mechanism along with the max-results parameter.</summary>
                [Google.Apis.Util.RequestParameterAttribute("start-index", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> StartIndex
                {
                    get
                    {
                        return this._startIndex;
                    }
                    set
                    {
                        this._startIndex = value;
                    }
                }

                /// <summary>An Analytics advanced segment to be applied to data.</summary>
                [Google.Apis.Util.RequestParameterAttribute("segment", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Segment
                {
                    get
                    {
                        return this._segment;
                    }
                    set
                    {
                        this._segment = value;
                    }
                }

                /// <summary>Unique table ID for retrieving Analytics data. Table ID is of the form ga:XXXX, where XXXX is the Analytics profile ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("ids", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Ids
                {
                    get
                    {
                        return this._ids;
                    }
                }

                /// <summary>A comma-separated list of Analytics metrics. E.g., 'ga:visits,ga:pageviews'. At least one metric must be specified.</summary>
                [Google.Apis.Util.RequestParameterAttribute("metrics", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Metrics
                {
                    get
                    {
                        return this._metrics;
                    }
                }

                /// <summary>A comma-separated list of dimension or metric filters to be applied to Analytics data.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filters", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filters
                {
                    get
                    {
                        return this._filters;
                    }
                    set
                    {
                        this._filters = value;
                    }
                }

                /// <summary>End date for fetching Analytics data. All requests should specify an end date formatted as YYYY-MM-DD.</summary>
                [Google.Apis.Util.RequestParameterAttribute("end-date", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string EndDate
                {
                    get
                    {
                        return this._endDate;
                    }
                }

                public override string ResourcePath
                {
                    get
                    {
                        return "data.ga";
                    }
                }

                public override string MethodName
                {
                    get
                    {
                        return "get";
                    }
                }

                public override string HttpMethod
                {
                    get
                    {
                        return "GET";
                    }
                }

                public override string RestPath
                {
                    get
                    {
                        return "data/ga";
                    }
                }

                private void InitParameters()
                {
                    System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter> parameters = new System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter>();
                    parameters.Add("max-results", Google.Apis.Util.Utilities.CreateRuntimeParameter("max-results", false, "query", null, null, new string[0]));
                    parameters.Add("sort", Google.Apis.Util.Utilities.CreateRuntimeParameter("sort", false, "query", null, "(-)?ga:.+", new string[0]));
                    parameters.Add("dimensions", Google.Apis.Util.Utilities.CreateRuntimeParameter("dimensions", false, "query", null, "(ga:.+)?", new string[0]));
                    parameters.Add("start-date", Google.Apis.Util.Utilities.CreateRuntimeParameter("start-date", true, "query", null, "[0-9]{4}-[0-9]{2}-[0-9]{2}", new string[0]));
                    parameters.Add("start-index", Google.Apis.Util.Utilities.CreateRuntimeParameter("start-index", false, "query", null, null, new string[0]));
                    parameters.Add("segment", Google.Apis.Util.Utilities.CreateRuntimeParameter("segment", false, "query", null, null, new string[0]));
                    parameters.Add("ids", Google.Apis.Util.Utilities.CreateRuntimeParameter("ids", true, "query", null, "ga:[0-9]+", new string[0]));
                    parameters.Add("metrics", Google.Apis.Util.Utilities.CreateRuntimeParameter("metrics", true, "query", null, "ga:.+", new string[0]));
                    parameters.Add("filters", Google.Apis.Util.Utilities.CreateRuntimeParameter("filters", false, "query", null, "ga:.+", new string[0]));
                    parameters.Add("end-date", Google.Apis.Util.Utilities.CreateRuntimeParameter("end-date", true, "query", null, "[0-9]{4}-[0-9]{2}-[0-9]{2}", new string[0]));
                    this._requestParameters = new Google.Apis.Util.ReadOnlyDictionary<string, Google.Apis.Discovery.IParameter>(parameters);
                }
            }
        }


        /*public GaData Fetch()
        {
            _ga.Get(
        }*/
    }

}
