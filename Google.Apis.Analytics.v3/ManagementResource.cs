namespace Google.Apis.Analytics.v3
{
    public class ManagementResource
    {

        private AnalyticsService service;

        private Google.Apis.Authentication.IAuthenticator authenticator;

        private const string Resource = "management";

        private DailyUploadsResource _dailyUploads;

        private SegmentsResource _segments;

        private ProfilesResource _profiles;

        private CustomDataSourcesResource _customDataSources;

        private GoalsResource _goals;

        private AccountsResource _accounts;

        private WebpropertiesResource _webproperties;

        public ManagementResource(AnalyticsService service, Google.Apis.Authentication.IAuthenticator authenticator)
        {
            this.service = service;
            this.authenticator = authenticator;
            this._dailyUploads = new DailyUploadsResource(service, authenticator);
            this._segments = new SegmentsResource(service, authenticator);
            this._profiles = new ProfilesResource(service, authenticator);
            this._customDataSources = new CustomDataSourcesResource(service, authenticator);
            this._goals = new GoalsResource(service, authenticator);
            this._accounts = new AccountsResource(service, authenticator);
            this._webproperties = new WebpropertiesResource(service, authenticator);
        }

        public virtual DailyUploadsResource DailyUploads
        {
            get
            {
                return this._dailyUploads;
            }
        }

        public virtual SegmentsResource Segments
        {
            get
            {
                return this._segments;
            }
        }

        public virtual ProfilesResource Profiles
        {
            get
            {
                return this._profiles;
            }
        }

        public virtual CustomDataSourcesResource CustomDataSources
        {
            get
            {
                return this._customDataSources;
            }
        }

        public virtual GoalsResource Goals
        {
            get
            {
                return this._goals;
            }
        }

        public virtual AccountsResource Accounts
        {
            get
            {
                return this._accounts;
            }
        }

        public virtual WebpropertiesResource Webproperties
        {
            get
            {
                return this._webproperties;
            }
        }

        public class DailyUploadsResource
        {

            private AnalyticsService service;

            private Google.Apis.Authentication.IAuthenticator authenticator;

            private const string Resource = "management.dailyUploads";

            public DailyUploadsResource(AnalyticsService service, Google.Apis.Authentication.IAuthenticator authenticator)
            {
                this.service = service;
                this.authenticator = authenticator;
            }

            /// <summary>List daily uploads to which the user has access.</summary>
            /// <param name="accountId">Required - Must match pattern \d+ - Account Id for the daily uploads to retrieve.</param>
            /// <param name="webPropertyId">Required - Must match pattern UA-(\d+)-(\d+) - Web property Id for the daily uploads to retrieve.</param>
            /// <param name="customDataSourceId">Required - Must match pattern .{22} - Custom data source Id for daily uploads to retrieve.</param>
            /// <param name="startDate">start-date - Required - Must match pattern [0-9]{4}-[0-9]{2}-[0-9]{2} - Start date of the form YYYY-MM-DD.</param>
            /// <param name="endDate">end-date - Required - Must match pattern [0-9]{4}-[0-9]{2}-[0-9]{2} - End date of the form YYYY-MM-DD.</param>
            public virtual ListRequest List(string accountId, string webPropertyId, string customDataSourceId, string startDate, string endDate)
            {
                return new ListRequest(service, accountId, webPropertyId, customDataSourceId, startDate, endDate);
            }

            /// <summary>Update/Overwrite data for a custom data source.</summary>
            /// <param name="accountId">Required - Must match pattern \d+ - Account Id associated with daily upload.</param>
            /// <param name="webPropertyId">Required - Must match pattern UA-\d+-\d+ - Web property Id associated with daily upload.</param>
            /// <param name="customDataSourceId">Required - Custom data source Id to which the data being uploaded belongs.</param>
            /// <param name="date">Required - Must match pattern [0-9]{4}-[0-9]{2}-[0-9]{2} - Date for which data is uploaded. Date should be formatted as YYYY-MM-DD.</param>
            /// <param name="appendNumber">Required - Minimum value of 1 - Maximum value of 20 - Append number for this upload indexed from 1.</param>
            /// <param name="type">Required - Must be one of the following values [cost] - Type of data for this upload.</param>
            public virtual UploadRequest Upload(string accountId, string webPropertyId, string customDataSourceId, string date, long appendNumber, Type type)
            {
                return new UploadRequest(service, accountId, webPropertyId, customDataSourceId, date, appendNumber, type);
            }

            /// <summary>Update/Overwrite data for a custom data source.</summary>
            /// <param name="accountId">Required - Must match pattern \d+ - Account Id associated with daily upload.</param>
            /// <param name="webPropertyId">Required - Must match pattern UA-\d+-\d+ - Web property Id associated with daily upload.</param>
            /// <param name="customDataSourceId">Required - Custom data source Id to which the data being uploaded belongs.</param>
            /// <param name="date">Required - Must match pattern [0-9]{4}-[0-9]{2}-[0-9]{2} - Date for which data is uploaded. Date should be formatted as YYYY-MM-DD.</param>
            /// <param name="appendNumber">Required - Minimum value of 1 - Maximum value of 20 - Append number for this upload indexed from 1.</param>
            /// <param name="type">Required - Must be one of the following values [cost] - Type of data for this upload.</param>
            public virtual UploadMediaUpload Upload(string accountId, string webPropertyId, string customDataSourceId, string date, long appendNumber, Type type, System.IO.Stream stream, string contentType)
            {
                return new UploadMediaUpload(service, accountId, webPropertyId, customDataSourceId, date, appendNumber, type, stream, contentType);
            }

            /// <summary>Delete uploaded data for the given date.</summary>
            /// <param name="accountId">Required - Must match pattern [0-9]+ - Account Id associated with daily upload delete.</param>
            /// <param name="webPropertyId">Required - Must match pattern UA-[0-9]+-[0-9]+ - Web property Id associated with daily upload delete.</param>
            /// <param name="customDataSourceId">Required - Custom data source Id associated with daily upload delete.</param>
            /// <param name="date">Required - Must match pattern [0-9]{4}-[0-9]{2}-[0-9]{2} - Date for which data is to be deleted. Date should be formatted as YYYY-MM-DD.</param>
            /// <param name="type">Required - Must be one of the following values [cost] - Type of data for this delete.</param>
            public virtual DeleteRequest Delete(string accountId, string webPropertyId, string customDataSourceId, string date, Type type)
            {
                return new DeleteRequest(service, accountId, webPropertyId, customDataSourceId, date, type);
            }

            /// <summary>Type of data for this upload.</summary>
            [System.ComponentModel.TypeConverterAttribute(typeof(Google.Apis.Util.EnumStringValueTypeConverter))]
            public enum Type
            {

                /// <summary>Value for specifying cost data upload.</summary>
                [Google.Apis.Util.StringValueAttribute("cost")]
                Cost,
            }

            public class ListRequest : Google.Apis.Requests.ClientServiceRequest<Google.Apis.Analytics.v3.Data.DailyUploads>
            {

                private System.Nullable<bool> _prettyPrint;

                private string _fields;

                private string _quotaUser;

                private string _oauth_token;

                private string _userIp;

                private string _alt;

                private System.Nullable<long> _maxResults;

                private string _startDate;

                private System.Nullable<long> _startIndex;

                private string _customDataSourceId;

                private string _webPropertyId;

                private string _endDate;

                private string _accountId;

                public ListRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId, string customDataSourceId, string startDate, string endDate) :
                    base(service)
                {
                    this._accountId = accountId;
                    this._webPropertyId = webPropertyId;
                    this._customDataSourceId = customDataSourceId;
                    this._startDate = startDate;
                    this._endDate = endDate;
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

                /// <summary>The maximum number of custom data sources to include in this response.</summary>
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

                /// <summary>Start date of the form YYYY-MM-DD.</summary>
                [Google.Apis.Util.RequestParameterAttribute("start-date", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string StartDate
                {
                    get
                    {
                        return this._startDate;
                    }
                }

                /// <summary>A 1-based index of the first daily upload to retrieve. Use this parameter as a pagination mechanism along with the max-results parameter.</summary>
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

                /// <summary>Custom data source Id for daily uploads to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("customDataSourceId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CustomDataSourceId
                {
                    get
                    {
                        return this._customDataSourceId;
                    }
                }

                /// <summary>Web property Id for the daily uploads to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId
                {
                    get
                    {
                        return this._webPropertyId;
                    }
                }

                /// <summary>End date of the form YYYY-MM-DD.</summary>
                [Google.Apis.Util.RequestParameterAttribute("end-date", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string EndDate
                {
                    get
                    {
                        return this._endDate;
                    }
                }

                /// <summary>Account Id for the daily uploads to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId
                {
                    get
                    {
                        return this._accountId;
                    }
                }

                public override string ResourcePath
                {
                    get
                    {
                        return "management.dailyUploads";
                    }
                }

                public override string MethodName
                {
                    get
                    {
                        return "list";
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
                        return "management/accounts/{accountId}/webproperties/{webPropertyId}/customDataSources/{customDataSourceId}/dailyUploads";
                    }
                }

                private void InitParameters()
                {
                    System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter> parameters = new System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter>();
                    parameters.Add("max-results", Google.Apis.Util.Utilities.CreateRuntimeParameter("max-results", false, "query", null, null, new string[0]));
                    parameters.Add("start-date", Google.Apis.Util.Utilities.CreateRuntimeParameter("start-date", true, "query", null, "[0-9]{4}-[0-9]{2}-[0-9]{2}", new string[0]));
                    parameters.Add("start-index", Google.Apis.Util.Utilities.CreateRuntimeParameter("start-index", false, "query", null, null, new string[0]));
                    parameters.Add("customDataSourceId", Google.Apis.Util.Utilities.CreateRuntimeParameter("customDataSourceId", true, "path", null, ".{22}", new string[0]));
                    parameters.Add("webPropertyId", Google.Apis.Util.Utilities.CreateRuntimeParameter("webPropertyId", true, "path", null, "UA-(\\d+)-(\\d+)", new string[0]));
                    parameters.Add("end-date", Google.Apis.Util.Utilities.CreateRuntimeParameter("end-date", true, "query", null, "[0-9]{4}-[0-9]{2}-[0-9]{2}", new string[0]));
                    parameters.Add("accountId", Google.Apis.Util.Utilities.CreateRuntimeParameter("accountId", true, "path", null, "\\d+", new string[0]));
                    this._requestParameters = new Google.Apis.Util.ReadOnlyDictionary<string, Google.Apis.Discovery.IParameter>(parameters);
                }
            }

            public class UploadRequest : Google.Apis.Requests.ClientServiceRequest<Google.Apis.Analytics.v3.Data.DailyUploadAppend>
            {

                private System.Nullable<bool> _prettyPrint;

                private string _fields;

                private string _quotaUser;

                private string _oauth_token;

                private string _userIp;

                private string _alt;

                private System.Nullable<bool> _reset;

                private string _customDataSourceId;

                private long _appendNumber;

                private string _webPropertyId;

                private string _date;

                private Type _type;

                private string _accountId;

                public UploadRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId, string customDataSourceId, string date, long appendNumber, Type type) :
                    base(service)
                {
                    this._accountId = accountId;
                    this._webPropertyId = webPropertyId;
                    this._customDataSourceId = customDataSourceId;
                    this._date = date;
                    this._appendNumber = appendNumber;
                    this._type = type;
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

                /// <summary>Reset/Overwrite all previous appends for this date and start over with this file as the first upload.</summary>
                [Google.Apis.Util.RequestParameterAttribute("reset", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> Reset
                {
                    get
                    {
                        return this._reset;
                    }
                    set
                    {
                        this._reset = value;
                    }
                }

                /// <summary>Custom data source Id to which the data being uploaded belongs.</summary>
                [Google.Apis.Util.RequestParameterAttribute("customDataSourceId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CustomDataSourceId
                {
                    get
                    {
                        return this._customDataSourceId;
                    }
                }

                /// <summary>Append number for this upload indexed from 1.</summary>
                [Google.Apis.Util.RequestParameterAttribute("appendNumber", Google.Apis.Util.RequestParameterType.Query)]
                public virtual long AppendNumber
                {
                    get
                    {
                        return this._appendNumber;
                    }
                }

                /// <summary>Web property Id associated with daily upload.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId
                {
                    get
                    {
                        return this._webPropertyId;
                    }
                }

                /// <summary>Date for which data is uploaded. Date should be formatted as YYYY-MM-DD.</summary>
                [Google.Apis.Util.RequestParameterAttribute("date", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Date
                {
                    get
                    {
                        return this._date;
                    }
                }

                /// <summary>Type of data for this upload.</summary>
                [Google.Apis.Util.RequestParameterAttribute("type", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Type Type
                {
                    get
                    {
                        return this._type;
                    }
                }

                /// <summary>Account Id associated with daily upload.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId
                {
                    get
                    {
                        return this._accountId;
                    }
                }

                public override string ResourcePath
                {
                    get
                    {
                        return "management.dailyUploads";
                    }
                }

                public override string MethodName
                {
                    get
                    {
                        return "upload";
                    }
                }

                public override string HttpMethod
                {
                    get
                    {
                        return "POST";
                    }
                }

                public override string RestPath
                {
                    get
                    {
                        return "management/accounts/{accountId}/webproperties/{webPropertyId}/customDataSources/{customDataSourceId}/dailyUploads/{date}/uploads";
                    }
                }

                private void InitParameters()
                {
                    System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter> parameters = new System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter>();
                    parameters.Add("reset", Google.Apis.Util.Utilities.CreateRuntimeParameter("reset", false, "query", "false", null, new string[0]));
                    parameters.Add("customDataSourceId", Google.Apis.Util.Utilities.CreateRuntimeParameter("customDataSourceId", true, "path", null, null, new string[0]));
                    parameters.Add("appendNumber", Google.Apis.Util.Utilities.CreateRuntimeParameter("appendNumber", true, "query", null, null, new string[0]));
                    parameters.Add("webPropertyId", Google.Apis.Util.Utilities.CreateRuntimeParameter("webPropertyId", true, "path", null, "UA-\\d+-\\d+", new string[0]));
                    parameters.Add("date", Google.Apis.Util.Utilities.CreateRuntimeParameter("date", true, "path", null, "[0-9]{4}-[0-9]{2}-[0-9]{2}", new string[0]));
                    parameters.Add("type", Google.Apis.Util.Utilities.CreateRuntimeParameter("type", true, "query", null, null, new string[] {
                                    "cost"}));
                    parameters.Add("accountId", Google.Apis.Util.Utilities.CreateRuntimeParameter("accountId", true, "path", null, "\\d+", new string[0]));
                    this._requestParameters = new Google.Apis.Util.ReadOnlyDictionary<string, Google.Apis.Discovery.IParameter>(parameters);
                }
            }

            public class UploadMediaUpload : Google.Apis.Upload.ResumableUpload<string, Google.Apis.Analytics.v3.Data.DailyUploadAppend>
            {

                private System.Nullable<bool> _prettyPrint;

                private string _fields;

                private string _quotaUser;

                private string _oauth_token;

                private string _userIp;

                private string _alt;

                private System.Nullable<bool> _reset;

                private string _customDataSourceId;

                private long _appendNumber;

                private string _webPropertyId;

                private string _date;

                private Type _type;

                private string _accountId;

                public UploadMediaUpload(Google.Apis.Services.IClientService service, string accountId, string webPropertyId, string customDataSourceId, string date, long appendNumber, Type type, System.IO.Stream stream, string contentType) :
                    base(service.BaseUri, "/upload/analytics/v3/management/accounts/{accountId}/webproperties/{webPropertyId}/customDataSources/{customDataSourceId}/dailyUploads/{date}/uploads", "POST", stream, contentType)
                {
                    this.Authenticator = service.Authenticator;
                    this._accountId = accountId;
                    this._webPropertyId = webPropertyId;
                    this._customDataSourceId = customDataSourceId;
                    this._date = date;
                    this._appendNumber = appendNumber;
                    this._type = type;
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

                /// <summary>Reset/Overwrite all previous appends for this date and start over with this file as the first upload.</summary>
                [Google.Apis.Util.RequestParameterAttribute("reset", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> Reset
                {
                    get
                    {
                        return this._reset;
                    }
                    set
                    {
                        this._reset = value;
                    }
                }

                /// <summary>Custom data source Id to which the data being uploaded belongs.</summary>
                [Google.Apis.Util.RequestParameterAttribute("customDataSourceId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CustomDataSourceId
                {
                    get
                    {
                        return this._customDataSourceId;
                    }
                }

                /// <summary>Append number for this upload indexed from 1.</summary>
                [Google.Apis.Util.RequestParameterAttribute("appendNumber", Google.Apis.Util.RequestParameterType.Query)]
                public virtual long AppendNumber
                {
                    get
                    {
                        return this._appendNumber;
                    }
                }

                /// <summary>Web property Id associated with daily upload.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId
                {
                    get
                    {
                        return this._webPropertyId;
                    }
                }

                /// <summary>Date for which data is uploaded. Date should be formatted as YYYY-MM-DD.</summary>
                [Google.Apis.Util.RequestParameterAttribute("date", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Date
                {
                    get
                    {
                        return this._date;
                    }
                }

                /// <summary>Type of data for this upload.</summary>
                [Google.Apis.Util.RequestParameterAttribute("type", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Type Type
                {
                    get
                    {
                        return this._type;
                    }
                }

                /// <summary>Account Id associated with daily upload.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId
                {
                    get
                    {
                        return this._accountId;
                    }
                }
            }

            public class DeleteRequest : Google.Apis.Requests.ClientServiceRequest<string>
            {

                private System.Nullable<bool> _prettyPrint;

                private string _fields;

                private string _quotaUser;

                private string _oauth_token;

                private string _userIp;

                private string _alt;

                private string _date;

                private string _customDataSourceId;

                private Type _type;

                private string _webPropertyId;

                private string _accountId;

                public DeleteRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId, string customDataSourceId, string date, Type type) :
                    base(service)
                {
                    this._accountId = accountId;
                    this._webPropertyId = webPropertyId;
                    this._customDataSourceId = customDataSourceId;
                    this._date = date;
                    this._type = type;
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

                /// <summary>Date for which data is to be deleted. Date should be formatted as YYYY-MM-DD.</summary>
                [Google.Apis.Util.RequestParameterAttribute("date", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Date
                {
                    get
                    {
                        return this._date;
                    }
                }

                /// <summary>Custom data source Id associated with daily upload delete.</summary>
                [Google.Apis.Util.RequestParameterAttribute("customDataSourceId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CustomDataSourceId
                {
                    get
                    {
                        return this._customDataSourceId;
                    }
                }

                /// <summary>Type of data for this delete.</summary>
                [Google.Apis.Util.RequestParameterAttribute("type", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Type Type
                {
                    get
                    {
                        return this._type;
                    }
                }

                /// <summary>Web property Id associated with daily upload delete.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId
                {
                    get
                    {
                        return this._webPropertyId;
                    }
                }

                /// <summary>Account Id associated with daily upload delete.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId
                {
                    get
                    {
                        return this._accountId;
                    }
                }

                public override string ResourcePath
                {
                    get
                    {
                        return "management.dailyUploads";
                    }
                }

                public override string MethodName
                {
                    get
                    {
                        return "delete";
                    }
                }

                public override string HttpMethod
                {
                    get
                    {
                        return "DELETE";
                    }
                }

                public override string RestPath
                {
                    get
                    {
                        return "management/accounts/{accountId}/webproperties/{webPropertyId}/customDataSources/{customDataSourceId}/dailyUploads/{date}";
                    }
                }

                private void InitParameters()
                {
                    System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter> parameters = new System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter>();
                    parameters.Add("date", Google.Apis.Util.Utilities.CreateRuntimeParameter("date", true, "path", null, "[0-9]{4}-[0-9]{2}-[0-9]{2}", new string[0]));
                    parameters.Add("customDataSourceId", Google.Apis.Util.Utilities.CreateRuntimeParameter("customDataSourceId", true, "path", null, null, new string[0]));
                    parameters.Add("type", Google.Apis.Util.Utilities.CreateRuntimeParameter("type", true, "query", null, null, new string[] {
                                    "cost"}));
                    parameters.Add("webPropertyId", Google.Apis.Util.Utilities.CreateRuntimeParameter("webPropertyId", true, "path", null, "UA-[0-9]+-[0-9]+", new string[0]));
                    parameters.Add("accountId", Google.Apis.Util.Utilities.CreateRuntimeParameter("accountId", true, "path", null, "[0-9]+", new string[0]));
                    this._requestParameters = new Google.Apis.Util.ReadOnlyDictionary<string, Google.Apis.Discovery.IParameter>(parameters);
                }
            }
        }

        public class SegmentsResource
        {

            private AnalyticsService service;

            private Google.Apis.Authentication.IAuthenticator authenticator;

            private const string Resource = "management.segments";

            public SegmentsResource(AnalyticsService service, Google.Apis.Authentication.IAuthenticator authenticator)
            {
                this.service = service;
                this.authenticator = authenticator;
            }

            /// <summary>Lists advanced segments to which the user has access.</summary>
            public virtual ListRequest List()
            {
                return new ListRequest(service);
            }

            public class ListRequest : Google.Apis.Requests.ClientServiceRequest<Google.Apis.Analytics.v3.Data.Segments>
            {

                private System.Nullable<bool> _prettyPrint;

                private string _fields;

                private string _quotaUser;

                private string _oauth_token;

                private string _userIp;

                private string _alt;

                private System.Nullable<long> _maxResults;

                private System.Nullable<long> _startIndex;

                public ListRequest(Google.Apis.Services.IClientService service) :
                    base(service)
                {
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

                /// <summary>The maximum number of advanced segments to include in this response.</summary>
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

                /// <summary>An index of the first advanced segment to retrieve. Use this parameter as a pagination mechanism along with the max-results parameter.</summary>
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

                public override string ResourcePath
                {
                    get
                    {
                        return "management.segments";
                    }
                }

                public override string MethodName
                {
                    get
                    {
                        return "list";
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
                        return "management/segments";
                    }
                }

                private void InitParameters()
                {
                    System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter> parameters = new System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter>();
                    parameters.Add("max-results", Google.Apis.Util.Utilities.CreateRuntimeParameter("max-results", false, "query", null, null, new string[0]));
                    parameters.Add("start-index", Google.Apis.Util.Utilities.CreateRuntimeParameter("start-index", false, "query", null, null, new string[0]));
                    this._requestParameters = new Google.Apis.Util.ReadOnlyDictionary<string, Google.Apis.Discovery.IParameter>(parameters);
                }
            }
        }

        public class ProfilesResource
        {

            private AnalyticsService service;

            private Google.Apis.Authentication.IAuthenticator authenticator;

            private const string Resource = "management.profiles";

            public ProfilesResource(AnalyticsService service, Google.Apis.Authentication.IAuthenticator authenticator)
            {
                this.service = service;
                this.authenticator = authenticator;
            }

            /// <summary>Lists profiles to which the user has access.</summary>
            /// <param name="accountId">Required - Account ID for the profiles to retrieve. Can either be a specific account ID or &apos;~all&apos;, which refers to all the accounts to which the user has access.</param>
            /// <param name="webPropertyId">Required - Web property ID for the profiles to retrieve. Can either be a specific web property ID or &apos;~all&apos;, which refers to all the web properties to which the user has access.</param>
            public virtual ListRequest List(string accountId, string webPropertyId)
            {
                return new ListRequest(service, accountId, webPropertyId);
            }

            public class ListRequest : Google.Apis.Requests.ClientServiceRequest<Google.Apis.Analytics.v3.Data.Profiles>
            {

                private System.Nullable<bool> _prettyPrint;

                private string _fields;

                private string _quotaUser;

                private string _oauth_token;

                private string _userIp;

                private string _alt;

                private System.Nullable<long> _maxResults;

                private System.Nullable<long> _startIndex;

                private string _webPropertyId;

                private string _accountId;

                public ListRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId) :
                    base(service)
                {
                    this._accountId = accountId;
                    this._webPropertyId = webPropertyId;
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

                /// <summary>The maximum number of profiles to include in this response.</summary>
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

                /// <summary>Web property ID for the profiles to retrieve. Can either be a specific web property ID or '~all', which refers to all the web properties to which the user has access.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId
                {
                    get
                    {
                        return this._webPropertyId;
                    }
                }

                /// <summary>Account ID for the profiles to retrieve. Can either be a specific account ID or '~all', which refers to all the accounts to which the user has access.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId
                {
                    get
                    {
                        return this._accountId;
                    }
                }

                public override string ResourcePath
                {
                    get
                    {
                        return "management.profiles";
                    }
                }

                public override string MethodName
                {
                    get
                    {
                        return "list";
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
                        return "management/accounts/{accountId}/webproperties/{webPropertyId}/profiles";
                    }
                }

                private void InitParameters()
                {
                    System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter> parameters = new System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter>();
                    parameters.Add("max-results", Google.Apis.Util.Utilities.CreateRuntimeParameter("max-results", false, "query", null, null, new string[0]));
                    parameters.Add("start-index", Google.Apis.Util.Utilities.CreateRuntimeParameter("start-index", false, "query", null, null, new string[0]));
                    parameters.Add("webPropertyId", Google.Apis.Util.Utilities.CreateRuntimeParameter("webPropertyId", true, "path", null, null, new string[0]));
                    parameters.Add("accountId", Google.Apis.Util.Utilities.CreateRuntimeParameter("accountId", true, "path", null, null, new string[0]));
                    this._requestParameters = new Google.Apis.Util.ReadOnlyDictionary<string, Google.Apis.Discovery.IParameter>(parameters);
                }
            }
        }

        public class CustomDataSourcesResource
        {

            private AnalyticsService service;

            private Google.Apis.Authentication.IAuthenticator authenticator;

            private const string Resource = "management.customDataSources";

            public CustomDataSourcesResource(AnalyticsService service, Google.Apis.Authentication.IAuthenticator authenticator)
            {
                this.service = service;
                this.authenticator = authenticator;
            }

            /// <summary>List custom data sources to which the user has access.</summary>
            /// <param name="accountId">Required - Must match pattern \d+ - Account Id for the custom data sources to retrieve.</param>
            /// <param name="webPropertyId">Required - Must match pattern UA-(\d+)-(\d+) - Web property Id for the custom data sources to retrieve.</param>
            public virtual ListRequest List(string accountId, string webPropertyId)
            {
                return new ListRequest(service, accountId, webPropertyId);
            }

            public class ListRequest : Google.Apis.Requests.ClientServiceRequest<Google.Apis.Analytics.v3.Data.CustomDataSources>
            {

                private System.Nullable<bool> _prettyPrint;

                private string _fields;

                private string _quotaUser;

                private string _oauth_token;

                private string _userIp;

                private string _alt;

                private System.Nullable<long> _maxResults;

                private System.Nullable<long> _startIndex;

                private string _webPropertyId;

                private string _accountId;

                public ListRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId) :
                    base(service)
                {
                    this._accountId = accountId;
                    this._webPropertyId = webPropertyId;
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

                /// <summary>The maximum number of custom data sources to include in this response.</summary>
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

                /// <summary>A 1-based index of the first custom data source to retrieve. Use this parameter as a pagination mechanism along with the max-results parameter.</summary>
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

                /// <summary>Web property Id for the custom data sources to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId
                {
                    get
                    {
                        return this._webPropertyId;
                    }
                }

                /// <summary>Account Id for the custom data sources to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId
                {
                    get
                    {
                        return this._accountId;
                    }
                }

                public override string ResourcePath
                {
                    get
                    {
                        return "management.customDataSources";
                    }
                }

                public override string MethodName
                {
                    get
                    {
                        return "list";
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
                        return "management/accounts/{accountId}/webproperties/{webPropertyId}/customDataSources";
                    }
                }

                private void InitParameters()
                {
                    System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter> parameters = new System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter>();
                    parameters.Add("max-results", Google.Apis.Util.Utilities.CreateRuntimeParameter("max-results", false, "query", null, null, new string[0]));
                    parameters.Add("start-index", Google.Apis.Util.Utilities.CreateRuntimeParameter("start-index", false, "query", null, null, new string[0]));
                    parameters.Add("webPropertyId", Google.Apis.Util.Utilities.CreateRuntimeParameter("webPropertyId", true, "path", null, "UA-(\\d+)-(\\d+)", new string[0]));
                    parameters.Add("accountId", Google.Apis.Util.Utilities.CreateRuntimeParameter("accountId", true, "path", null, "\\d+", new string[0]));
                    this._requestParameters = new Google.Apis.Util.ReadOnlyDictionary<string, Google.Apis.Discovery.IParameter>(parameters);
                }
            }
        }

        public class GoalsResource
        {

            private AnalyticsService service;

            private Google.Apis.Authentication.IAuthenticator authenticator;

            private const string Resource = "management.goals";

            public GoalsResource(AnalyticsService service, Google.Apis.Authentication.IAuthenticator authenticator)
            {
                this.service = service;
                this.authenticator = authenticator;
            }

            /// <summary>Lists goals to which the user has access.</summary>
            /// <param name="accountId">Required - Account ID to retrieve goals for. Can either be a specific account ID or &apos;~all&apos;, which refers to all the accounts that user has access to.</param>
            /// <param name="webPropertyId">Required - Web property ID to retrieve goals for. Can either be a specific web property ID or &apos;~all&apos;, which refers to all the web properties that user has access to.</param>
            /// <param name="profileId">Required - Profile ID to retrieve goals for. Can either be a specific profile ID or &apos;~all&apos;, which refers to all the profiles that user has access to.</param>
            public virtual ListRequest List(string accountId, string webPropertyId, string profileId)
            {
                return new ListRequest(service, accountId, webPropertyId, profileId);
            }

            public class ListRequest : Google.Apis.Requests.ClientServiceRequest<Google.Apis.Analytics.v3.Data.Goals>
            {

                private System.Nullable<bool> _prettyPrint;

                private string _fields;

                private string _quotaUser;

                private string _oauth_token;

                private string _userIp;

                private string _alt;

                private System.Nullable<long> _maxResults;

                private string _profileId;

                private System.Nullable<long> _startIndex;

                private string _webPropertyId;

                private string _accountId;

                public ListRequest(Google.Apis.Services.IClientService service, string accountId, string webPropertyId, string profileId) :
                    base(service)
                {
                    this._accountId = accountId;
                    this._webPropertyId = webPropertyId;
                    this._profileId = profileId;
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

                /// <summary>The maximum number of goals to include in this response.</summary>
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

                /// <summary>Profile ID to retrieve goals for. Can either be a specific profile ID or '~all', which refers to all the profiles that user has access to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("profileId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProfileId
                {
                    get
                    {
                        return this._profileId;
                    }
                }

                /// <summary>An index of the first goal to retrieve. Use this parameter as a pagination mechanism along with the max-results parameter.</summary>
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

                /// <summary>Web property ID to retrieve goals for. Can either be a specific web property ID or '~all', which refers to all the web properties that user has access to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("webPropertyId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string WebPropertyId
                {
                    get
                    {
                        return this._webPropertyId;
                    }
                }

                /// <summary>Account ID to retrieve goals for. Can either be a specific account ID or '~all', which refers to all the accounts that user has access to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId
                {
                    get
                    {
                        return this._accountId;
                    }
                }

                public override string ResourcePath
                {
                    get
                    {
                        return "management.goals";
                    }
                }

                public override string MethodName
                {
                    get
                    {
                        return "list";
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
                        return "management/accounts/{accountId}/webproperties/{webPropertyId}/profiles/{profileId}/goals";
                    }
                }

                private void InitParameters()
                {
                    System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter> parameters = new System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter>();
                    parameters.Add("max-results", Google.Apis.Util.Utilities.CreateRuntimeParameter("max-results", false, "query", null, null, new string[0]));
                    parameters.Add("profileId", Google.Apis.Util.Utilities.CreateRuntimeParameter("profileId", true, "path", null, null, new string[0]));
                    parameters.Add("start-index", Google.Apis.Util.Utilities.CreateRuntimeParameter("start-index", false, "query", null, null, new string[0]));
                    parameters.Add("webPropertyId", Google.Apis.Util.Utilities.CreateRuntimeParameter("webPropertyId", true, "path", null, null, new string[0]));
                    parameters.Add("accountId", Google.Apis.Util.Utilities.CreateRuntimeParameter("accountId", true, "path", null, null, new string[0]));
                    this._requestParameters = new Google.Apis.Util.ReadOnlyDictionary<string, Google.Apis.Discovery.IParameter>(parameters);
                }
            }
        }

        public class AccountsResource
        {

            private AnalyticsService service;

            private Google.Apis.Authentication.IAuthenticator authenticator;

            private const string Resource = "management.accounts";

            public AccountsResource(AnalyticsService service, Google.Apis.Authentication.IAuthenticator authenticator)
            {
                this.service = service;
                this.authenticator = authenticator;
            }

            /// <summary>Lists all accounts to which the user has access.</summary>
            public virtual ListRequest List()
            {
                return new ListRequest(service);
            }

            public class ListRequest : Google.Apis.Requests.ClientServiceRequest<Google.Apis.Analytics.v3.Data.Accounts>
            {

                private System.Nullable<bool> _prettyPrint;

                private string _fields;

                private string _quotaUser;

                private string _oauth_token;

                private string _userIp;

                private string _alt;

                private System.Nullable<long> _maxResults;

                private System.Nullable<long> _startIndex;

                public ListRequest(Google.Apis.Services.IClientService service) :
                    base(service)
                {
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

                /// <summary>The maximum number of accounts to include in this response.</summary>
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

                /// <summary>An index of the first account to retrieve. Use this parameter as a pagination mechanism along with the max-results parameter.</summary>
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

                public override string ResourcePath
                {
                    get
                    {
                        return "management.accounts";
                    }
                }

                public override string MethodName
                {
                    get
                    {
                        return "list";
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
                        return "management/accounts";
                    }
                }

                private void InitParameters()
                {
                    System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter> parameters = new System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter>();
                    parameters.Add("max-results", Google.Apis.Util.Utilities.CreateRuntimeParameter("max-results", false, "query", null, null, new string[0]));
                    parameters.Add("start-index", Google.Apis.Util.Utilities.CreateRuntimeParameter("start-index", false, "query", null, null, new string[0]));
                    this._requestParameters = new Google.Apis.Util.ReadOnlyDictionary<string, Google.Apis.Discovery.IParameter>(parameters);
                }
            }
        }

        public class WebpropertiesResource
        {

            private AnalyticsService service;

            private Google.Apis.Authentication.IAuthenticator authenticator;

            private const string Resource = "management.webproperties";

            public WebpropertiesResource(AnalyticsService service, Google.Apis.Authentication.IAuthenticator authenticator)
            {
                this.service = service;
                this.authenticator = authenticator;
            }

            /// <summary>Lists web properties to which the user has access.</summary>
            /// <param name="accountId">Required - Account ID to retrieve web properties for. Can either be a specific account ID or &apos;~all&apos;, which refers to all the accounts that user has access to.</param>
            public virtual ListRequest List(string accountId)
            {
                return new ListRequest(service, accountId);
            }

            public class ListRequest : Google.Apis.Requests.ClientServiceRequest<Google.Apis.Analytics.v3.Data.Webproperties>
            {

                private System.Nullable<bool> _prettyPrint;

                private string _fields;

                private string _quotaUser;

                private string _oauth_token;

                private string _userIp;

                private string _alt;

                private System.Nullable<long> _maxResults;

                private System.Nullable<long> _startIndex;

                private string _accountId;

                public ListRequest(Google.Apis.Services.IClientService service, string accountId) :
                    base(service)
                {
                    this._accountId = accountId;
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

                /// <summary>The maximum number of web properties to include in this response.</summary>
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

                /// <summary>Account ID to retrieve web properties for. Can either be a specific account ID or '~all', which refers to all the accounts that user has access to.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId
                {
                    get
                    {
                        return this._accountId;
                    }
                }

                public override string ResourcePath
                {
                    get
                    {
                        return "management.webproperties";
                    }
                }

                public override string MethodName
                {
                    get
                    {
                        return "list";
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
                        return "management/accounts/{accountId}/webproperties";
                    }
                }

                private void InitParameters()
                {
                    System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter> parameters = new System.Collections.Generic.Dictionary<string, Google.Apis.Discovery.IParameter>();
                    parameters.Add("max-results", Google.Apis.Util.Utilities.CreateRuntimeParameter("max-results", false, "query", null, null, new string[0]));
                    parameters.Add("start-index", Google.Apis.Util.Utilities.CreateRuntimeParameter("start-index", false, "query", null, null, new string[0]));
                    parameters.Add("accountId", Google.Apis.Util.Utilities.CreateRuntimeParameter("accountId", true, "path", null, null, new string[0]));
                    this._requestParameters = new Google.Apis.Util.ReadOnlyDictionary<string, Google.Apis.Discovery.IParameter>(parameters);
                }
            }
        }
    }

}
