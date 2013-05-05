namespace Google.Apis.Analytics.v3.Data
{

    /// <summary>Metadata for daily upload entity.</summary>
    public class DailyUpload
    {

        private System.Collections.Generic.IList<DailyUpload.RecentChangesData> _recentChanges;
        private string _kind;
        private string _modifiedTime;
        private System.Nullable<long> _appendCount;
        private string _customDataSourceId;
        private string _date;
        private string _webPropertyId;
        private string _createdTime;
        private DailyUpload.ParentLinkData _parentLink;
        private string _selfLink;
        private string _accountId;

        /// <summary>Change log for last 10 changes in chronological order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recentChanges")]
        public virtual System.Collections.Generic.IList<DailyUpload.RecentChangesData> RecentChanges
        {
            get
            {
                return this._recentChanges;
            }
            set
            {
                this._recentChanges = value;
            }
        }

        /// <summary>Resource type for Analytics daily upload.</summary>
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

        /// <summary>Time this daily upload was last modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modifiedTime")]
        public virtual string ModifiedTime
        {
            get
            {
                return this._modifiedTime;
            }
            set
            {
                this._modifiedTime = value;
            }
        }

        /// <summary>Number of appends for this date.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appendCount")]
        public virtual System.Nullable<long> AppendCount
        {
            get
            {
                return this._appendCount;
            }
            set
            {
                this._appendCount = value;
            }
        }

        /// <summary>Custom data source ID to which this daily upload belongs.</summary>
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

        /// <summary>Date associated with daily upload.</summary>
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

        /// <summary>Web property ID of the form UA-XXXXX-YY to which this daily upload belongs.</summary>
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

        /// <summary>Time this daily upload was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createdTime")]
        public virtual string CreatedTime
        {
            get
            {
                return this._createdTime;
            }
            set
            {
                this._createdTime = value;
            }
        }

        /// <summary>Parent link for a daily upload. Points to the custom data source to which this daily upload belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentLink")]
        public virtual DailyUpload.ParentLinkData ParentLink
        {
            get
            {
                return this._parentLink;
            }
            set
            {
                this._parentLink = value;
            }
        }

        /// <summary>Link for this daily upload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink
        {
            get
            {
                return this._selfLink;
            }
            set
            {
                this._selfLink = value;
            }
        }

        /// <summary>Account ID to which this daily upload belongs.</summary>
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

        public class RecentChangesData
        {

            private string _change;

            private string _time;

            [Newtonsoft.Json.JsonPropertyAttribute("change")]
            public virtual string Change
            {
                get
                {
                    return this._change;
                }
                set
                {
                    this._change = value;
                }
            }

            [Newtonsoft.Json.JsonPropertyAttribute("time")]
            public virtual string Time
            {
                get
                {
                    return this._time;
                }
                set
                {
                    this._time = value;
                }
            }
        }

        /// <summary>Parent link for a daily upload. Points to the custom data source to which this daily upload belongs.</summary>
        public class ParentLinkData
        {

            private string _href;

            private string _type;

            /// <summary>Link to the custom data source to which this daily upload belongs.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("href")]
            public virtual string Href
            {
                get
                {
                    return this._href;
                }
                set
                {
                    this._href = value;
                }
            }

            /// <summary>Value is &quot;analytics#customDataSource&quot;.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type
            {
                get
                {
                    return this._type;
                }
                set
                {
                    this._type = value;
                }
            }
        }
    }

}
