namespace Google.Apis.Analytics.v3.Data
{

    /// <summary>A daily upload collection lists Analytics daily uploads to which the user has access. Each resource in the collection corresponds to a single Analytics daily upload.</summary>
    public class DailyUploads : Google.Apis.Requests.IDirectResponseSchema
    {

        private string _username;

        private string _kind;

        private System.Collections.Generic.IList<DailyUpload> _items;

        private System.Nullable<long> _itemsPerPage;

        private string _previousLink;

        private System.Nullable<long> _startIndex;

        private string _nextLink;

        private System.Nullable<long> _totalResults;

        private string _ETag;

        /// <summary>Email ID of the authenticated user</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username
        {
            get
            {
                return this._username;
            }
            set
            {
                this._username = value;
            }
        }

        /// <summary>Collection type. Value is analytics#dailyUploads.</summary>
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

        /// <summary>A collection of daily uploads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<DailyUpload> Items
        {
            get
            {
                return this._items;
            }
            set
            {
                this._items = value;
            }
        }

        /// <summary>The maximum number of resources the response can contain, regardless of the actual number of resources returned. Its value ranges from 1 to 1000 with a value of 1000 by default, or otherwise specified by the max-results query parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemsPerPage")]
        public virtual System.Nullable<long> ItemsPerPage
        {
            get
            {
                return this._itemsPerPage;
            }
            set
            {
                this._itemsPerPage = value;
            }
        }

        /// <summary>Link to previous page for this daily upload collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previousLink")]
        public virtual string PreviousLink
        {
            get
            {
                return this._previousLink;
            }
            set
            {
                this._previousLink = value;
            }
        }

        /// <summary>The starting index of the resources, which is 1 by default or otherwise specified by the start-index query parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
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

        /// <summary>Link to next page for this daily upload collection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextLink")]
        public virtual string NextLink
        {
            get
            {
                return this._nextLink;
            }
            set
            {
                this._nextLink = value;
            }
        }

        /// <summary>The total number of results for the query, regardless of the number of results in the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalResults")]
        public virtual System.Nullable<long> TotalResults
        {
            get
            {
                return this._totalResults;
            }
            set
            {
                this._totalResults = value;
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
