namespace Google.Apis.Analytics.v3.Data
{
    /// <summary>Metadata returned for a successful append operation.</summary>
    public class DailyUploadAppend : Google.Apis.Requests.IDirectResponseSchema, IDailyUploadAppend
    {

        private string _kind;

        private string _customDataSourceId;

        private System.Nullable<long> _appendNumber;

        private string _webPropertyId;

        private string _date;

        private string _nextAppendLink;

        private string _accountId;

        private string _ETag;

        /// <summary>Resource type for Analytics daily upload append.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind
        {
            get
            {
                return this._kind;
            }
            set
            {
                this._kind = value;
            }
        }

        /// <summary>Custom data source Id to which this daily upload append belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customDataSourceId")]
        public virtual string CustomDataSourceId
        {
            get
            {
                return this._customDataSourceId;
            }
            set
            {
                this._customDataSourceId = value;
            }
        }

        /// <summary>Append number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appendNumber")]
        public virtual System.Nullable<long> AppendNumber
        {
            get
            {
                return this._appendNumber;
            }
            set
            {
                this._appendNumber = value;
            }
        }

        /// <summary>Web property Id of the form UA-XXXXX-YY to which this daily upload append belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webPropertyId")]
        public virtual string WebPropertyId
        {
            get
            {
                return this._webPropertyId;
            }
            set
            {
                this._webPropertyId = value;
            }
        }

        /// <summary>Date associated with daily upload append.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual string Date
        {
            get
            {
                return this._date;
            }
            set
            {
                this._date = value;
            }
        }

        [Newtonsoft.Json.JsonPropertyAttribute("nextAppendLink")]
        public virtual string NextAppendLink
        {
            get
            {
                return this._nextAppendLink;
            }
            set
            {
                this._nextAppendLink = value;
            }
        }

        /// <summary>Account Id to which this daily upload append belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId
        {
            get
            {
                return this._accountId;
            }
            set
            {
                this._accountId = value;
            }
        }

        public virtual string ETag
        {
            get
            {
                return this._ETag;
            }
            set
            {
                this._ETag = value;
            }
        }
    }

}
