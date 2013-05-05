namespace Google.Apis.Analytics.v3.Data
{
    /// <summary>Multi-Channel Funnels data for a given profile.</summary>
    public class McfData : Google.Apis.Requests.IDirectResponseSchema
    {

        private string _kind;

        private System.Collections.Generic.IList<System.Collections.Generic.IList<McfData.RowsData>> _rows;

        private System.Nullable<bool> _containsSampledData;

        private System.Nullable<long> _totalResults;

        private System.Nullable<long> _itemsPerPage;

        private McfData.TotalsForAllResultsData _totalsForAllResults;

        private string _nextLink;

        private string _id;

        private McfData.QueryData _query;

        private string _previousLink;

        private McfData.ProfileInfoData _profileInfo;

        private System.Collections.Generic.IList<McfData.ColumnHeadersData> _columnHeaders;

        private string _selfLink;

        private string _ETag;

        /// <summary>Resource type.</summary>
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

        /// <summary>Analytics data rows, where each row contains a list of dimension values followed by the metric values. The order of dimensions and metrics is same as specified in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IList<McfData.RowsData>> Rows
        {
            get
            {
                return this._rows;
            }
            set
            {
                this._rows = value;
            }
        }

        /// <summary>Determines if the Analytics data contains sampled data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containsSampledData")]
        public virtual System.Nullable<bool> ContainsSampledData
        {
            get
            {
                return this._containsSampledData;
            }
            set
            {
                this._containsSampledData = value;
            }
        }

        /// <summary>The total number of rows for the query, regardless of the number of rows in the response.</summary>
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

        /// <summary>The maximum number of rows the response can contain, regardless of the actual number of rows returned. Its value ranges from 1 to 10,000 with a value of 1000 by default, or otherwise specified by the max-results query parameter.</summary>
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

        /// <summary>Total values for the requested metrics over all the results, not just the results returned in this response. The order of the metric totals is same as the metric order specified in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalsForAllResults")]
        public virtual McfData.TotalsForAllResultsData TotalsForAllResults
        {
            get
            {
                return this._totalsForAllResults;
            }
            set
            {
                this._totalsForAllResults = value;
            }
        }

        /// <summary>Link to next page for this Analytics data query.</summary>
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

        /// <summary>Unique ID for this data response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }

        /// <summary>Analytics data request query parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual McfData.QueryData Query
        {
            get
            {
                return this._query;
            }
            set
            {
                this._query = value;
            }
        }

        /// <summary>Link to previous page for this Analytics data query.</summary>
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

        /// <summary>Information for the profile, for which the Analytics data was requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profileInfo")]
        public virtual McfData.ProfileInfoData ProfileInfo
        {
            get
            {
                return this._profileInfo;
            }
            set
            {
                this._profileInfo = value;
            }
        }

        /// <summary>Column headers that list dimension names followed by the metric names. The order of dimensions and metrics is same as specified in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnHeaders")]
        public virtual System.Collections.Generic.IList<McfData.ColumnHeadersData> ColumnHeaders
        {
            get
            {
                return this._columnHeaders;
            }
            set
            {
                this._columnHeaders = value;
            }
        }

        /// <summary>Link to this page.</summary>
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

        /// <summary>A union object representing a dimension or metric value. Only one of &quot;primitiveValue&quot; or &quot;conversionPathValue&quot; attribute will be populated.</summary>
        public class RowsData
        {

            private string _primitiveValue;

            private System.Collections.Generic.IList<RowsData.ConversionPathValueData> _conversionPathValue;

            /// <summary>A primitive dimension value. A primitive metric value.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("primitiveValue")]
            public virtual string PrimitiveValue
            {
                get
                {
                    return this._primitiveValue;
                }
                set
                {
                    this._primitiveValue = value;
                }
            }

            /// <summary>A conversion path dimension value, containing a list of interactions with their attributes.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("conversionPathValue")]
            public virtual System.Collections.Generic.IList<RowsData.ConversionPathValueData> ConversionPathValue
            {
                get
                {
                    return this._conversionPathValue;
                }
                set
                {
                    this._conversionPathValue = value;
                }
            }

            public class ConversionPathValueData
            {

                private string _nodeValue;

                private string _interactionType;

                /// <summary>Node value of an interaction on conversion path. Such as source, medium etc.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("nodeValue")]
                public virtual string NodeValue
                {
                    get
                    {
                        return this._nodeValue;
                    }
                    set
                    {
                        this._nodeValue = value;
                    }
                }

                /// <summary>Type of an interaction on conversion path. Such as CLICK, IMPRESSION etc.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("interactionType")]
                public virtual string InteractionType
                {
                    get
                    {
                        return this._interactionType;
                    }
                    set
                    {
                        this._interactionType = value;
                    }
                }
            }
        }

        /// <summary>Total values for the requested metrics over all the results, not just the results returned in this response. The order of the metric totals is same as the metric order specified in the request.</summary>
        public class TotalsForAllResultsData : System.Collections.Generic.Dictionary<string, string>
        {
        }

        /// <summary>Analytics data request query parameters.</summary>
        public class QueryData
        {

            private System.Nullable<long> _maxResults;

            private System.Collections.Generic.IList<string> _sort;

            private string _dimensions;

            private string _startDate;

            private System.Nullable<long> _startIndex;

            private string _segment;

            private string _ids;

            private System.Collections.Generic.IList<string> _metrics;

            private string _filters;

            private string _endDate;

            /// <summary>Maximum results per page.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("max-results")]
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

            /// <summary>List of dimensions or metrics based on which Analytics data is sorted.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("sort")]
            public virtual System.Collections.Generic.IList<string> Sort
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

            /// <summary>List of analytics dimensions.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
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

            /// <summary>Start date.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("start-date")]
            public virtual string StartDate
            {
                get
                {
                    return this._startDate;
                }
                set
                {
                    this._startDate = value;
                }
            }

            /// <summary>Start index.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("start-index")]
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

            /// <summary>Analytics advanced segment.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("segment")]
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

            /// <summary>Unique table ID.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("ids")]
            public virtual string Ids
            {
                get
                {
                    return this._ids;
                }
                set
                {
                    this._ids = value;
                }
            }

            /// <summary>List of analytics metrics.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
            public virtual System.Collections.Generic.IList<string> Metrics
            {
                get
                {
                    return this._metrics;
                }
                set
                {
                    this._metrics = value;
                }
            }

            /// <summary>Comma-separated list of dimension or metric filters.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("filters")]
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

            /// <summary>End date.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("end-date")]
            public virtual string EndDate
            {
                get
                {
                    return this._endDate;
                }
                set
                {
                    this._endDate = value;
                }
            }
        }

        /// <summary>Information for the profile, for which the Analytics data was requested.</summary>
        public class ProfileInfoData
        {

            private string _webPropertyId;

            private string _internalWebPropertyId;

            private string _tableId;

            private string _profileId;

            private string _profileName;

            private string _accountId;

            /// <summary>Web Property ID to which this profile belongs.</summary>
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

            /// <summary>Internal ID for the web property to which this profile belongs.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("internalWebPropertyId")]
            public virtual string InternalWebPropertyId
            {
                get
                {
                    return this._internalWebPropertyId;
                }
                set
                {
                    this._internalWebPropertyId = value;
                }
            }

            /// <summary>Table ID for profile.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("tableId")]
            public virtual string TableId
            {
                get
                {
                    return this._tableId;
                }
                set
                {
                    this._tableId = value;
                }
            }

            /// <summary>Profile ID.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("profileId")]
            public virtual string ProfileId
            {
                get
                {
                    return this._profileId;
                }
                set
                {
                    this._profileId = value;
                }
            }

            /// <summary>Profile name.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("profileName")]
            public virtual string ProfileName
            {
                get
                {
                    return this._profileName;
                }
                set
                {
                    this._profileName = value;
                }
            }

            /// <summary>Account ID to which this profile belongs.</summary>
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
        }

        public class ColumnHeadersData
        {

            private string _dataType;

            private string _columnType;

            private string _name;

            /// <summary>Data type. Dimension and metric values data types such as INTEGER, DOUBLE, CURRENCY, MCF_SEQUENCE etc.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
            public virtual string DataType
            {
                get
                {
                    return this._dataType;
                }
                set
                {
                    this._dataType = value;
                }
            }

            /// <summary>Column Type. Either DIMENSION or METRIC.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("columnType")]
            public virtual string ColumnType
            {
                get
                {
                    return this._columnType;
                }
                set
                {
                    this._columnType = value;
                }
            }

            /// <summary>Column name.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("name")]
            public virtual string Name
            {
                get
                {
                    return this._name;
                }
                set
                {
                    this._name = value;
                }
            }
        }
    }

    
}
