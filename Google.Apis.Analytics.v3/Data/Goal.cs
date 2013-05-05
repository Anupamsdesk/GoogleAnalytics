namespace Google.Apis.Analytics.v3.Data
{
    /// <summary>JSON template for Analytics goal resource.</summary>
    public class Goal
    {
        private string _kind;
        private Goal.VisitTimeOnSiteDetailsData _visitTimeOnSiteDetails;
        private string _name;
        private string _created;
        private Goal.UrlDestinationDetailsData _urlDestinationDetails;
        private string _updated;
        private System.Nullable<double> _value;
        private Goal.VisitNumPagesDetailsData _visitNumPagesDetails;
        private string _internalWebPropertyId;
        private Goal.EventDetailsData _eventDetails;
        private string _webPropertyId;
        private System.Nullable<bool> _active;
        private string _profileId;
        private Goal.ParentLinkData _parentLink;
        private string _type;
        private string _id;
        private string _selfLink;
        private string _accountId;
        
        /// <summary>Resource type for an Analytics goal.</summary>
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

        /// <summary>Details for the goal of the type VISIT_TIME_ON_SITE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visitTimeOnSiteDetails")]
        public virtual Goal.VisitTimeOnSiteDetailsData VisitTimeOnSiteDetails
        {
            get
            {
                return this._visitTimeOnSiteDetails;
            }
            set
            {
                this._visitTimeOnSiteDetails = value;
            }
        }

        /// <summary>Goal name.</summary>
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

        /// <summary>Time this goal was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("created")]
        public virtual string Created
        {
            get
            {
                return this._created;
            }
            set
            {
                this._created = value;
            }
        }

        /// <summary>Details for the goal of the type URL_DESTINATION.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("urlDestinationDetails")]
        public virtual Goal.UrlDestinationDetailsData UrlDestinationDetails
        {
            get
            {
                return this._urlDestinationDetails;
            }
            set
            {
                this._urlDestinationDetails = value;
            }
        }

        /// <summary>Time this goal was last modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updated")]
        public virtual string Updated
        {
            get
            {
                return this._updated;
            }
            set
            {
                this._updated = value;
            }
        }

        /// <summary>Goal value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<double> Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }

        /// <summary>Details for the goal of the type VISIT_NUM_PAGES.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visitNumPagesDetails")]
        public virtual Goal.VisitNumPagesDetailsData VisitNumPagesDetails
        {
            get
            {
                return this._visitNumPagesDetails;
            }
            set
            {
                this._visitNumPagesDetails = value;
            }
        }

        /// <summary>Internal ID for the web property to which this goal belongs.</summary>
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

        /// <summary>Details for the goal of the type EVENT.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventDetails")]
        public virtual Goal.EventDetailsData EventDetails
        {
            get
            {
                return this._eventDetails;
            }
            set
            {
                this._eventDetails = value;
            }
        }

        /// <summary>Web property ID to which this goal belongs. The web property ID is of the form UA-XXXXX-YY.</summary>
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

        /// <summary>Determines whether this goal is active.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("active")]
        public virtual System.Nullable<bool> Active
        {
            get
            {
                return this._active;
            }
            set
            {
                this._active = value;
            }
        }

        /// <summary>Profile ID to which this goal belongs.</summary>
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

        /// <summary>Parent link for a goal. Points to the profile to which this goal belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentLink")]
        public virtual Goal.ParentLinkData ParentLink
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

        /// <summary>Goal type. Possible values are URL_DESTINATION, VISIT_TIME_ON_SITE, VISIT_NUM_PAGES, AND EVENT.</summary>
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

        /// <summary>Goal ID.</summary>
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

        /// <summary>Link for this goal.</summary>
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

        /// <summary>Account ID to which this goal belongs.</summary>
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

        /// <summary>Details for the goal of the type VISIT_TIME_ON_SITE.</summary>
        public class VisitTimeOnSiteDetailsData
        {

            private string _comparisonType;

            private string _comparisonValue;

            /// <summary>Type of comparison. Possible values are LESS_THAN or GREATER_THAN.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("comparisonType")]
            public virtual string ComparisonType
            {
                get
                {
                    return this._comparisonType;
                }
                set
                {
                    this._comparisonType = value;
                }
            }

            /// <summary>Value used for this comparison.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("comparisonValue")]
            public virtual string ComparisonValue
            {
                get
                {
                    return this._comparisonValue;
                }
                set
                {
                    this._comparisonValue = value;
                }
            }
        }

        /// <summary>Details for the goal of the type URL_DESTINATION.</summary>
        public class UrlDestinationDetailsData
        {

            private string _url;

            private System.Nullable<bool> _caseSensitive;

            private string _matchType;

            private System.Collections.Generic.IList<UrlDestinationDetailsData.StepsData> _steps;

            private System.Nullable<bool> _firstStepRequired;

            /// <summary>URL for this goal.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("url")]
            public virtual string Url
            {
                get
                {
                    return this._url;
                }
                set
                {
                    this._url = value;
                }
            }

            /// <summary>Determines if the goal URL must exactly match the capitalization of visited URLs.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("caseSensitive")]
            public virtual System.Nullable<bool> CaseSensitive
            {
                get
                {
                    return this._caseSensitive;
                }
                set
                {
                    this._caseSensitive = value;
                }
            }

            /// <summary>Match type for the goal URL. Possible values are HEAD, EXACT, or REGEX.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("matchType")]
            public virtual string MatchType
            {
                get
                {
                    return this._matchType;
                }
                set
                {
                    this._matchType = value;
                }
            }

            /// <summary>List of steps configured for this goal funnel.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("steps")]
            public virtual System.Collections.Generic.IList<UrlDestinationDetailsData.StepsData> Steps
            {
                get
                {
                    return this._steps;
                }
                set
                {
                    this._steps = value;
                }
            }

            /// <summary>Determines if the first step in this goal is required.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("firstStepRequired")]
            public virtual System.Nullable<bool> FirstStepRequired
            {
                get
                {
                    return this._firstStepRequired;
                }
                set
                {
                    this._firstStepRequired = value;
                }
            }

            public class StepsData
            {

                private string _url;

                private string _name;

                private System.Nullable<long> _number;

                /// <summary>URL for this step.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("url")]
                public virtual string Url
                {
                    get
                    {
                        return this._url;
                    }
                    set
                    {
                        this._url = value;
                    }
                }

                /// <summary>Step name.</summary>
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

                /// <summary>Step number.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("number")]
                public virtual System.Nullable<long> Number
                {
                    get
                    {
                        return this._number;
                    }
                    set
                    {
                        this._number = value;
                    }
                }
            }
        }

        /// <summary>Details for the goal of the type VISIT_NUM_PAGES.</summary>
        public class VisitNumPagesDetailsData
        {

            private string _comparisonType;

            private string _comparisonValue;

            /// <summary>Type of comparison. Possible values are LESS_THAN, GREATER_THAN, or EQUAL.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("comparisonType")]
            public virtual string ComparisonType
            {
                get
                {
                    return this._comparisonType;
                }
                set
                {
                    this._comparisonType = value;
                }
            }

            /// <summary>Value used for this comparison.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("comparisonValue")]
            public virtual string ComparisonValue
            {
                get
                {
                    return this._comparisonValue;
                }
                set
                {
                    this._comparisonValue = value;
                }
            }
        }

        /// <summary>Details for the goal of the type EVENT.</summary>
        public class EventDetailsData
        {

            private System.Collections.Generic.IList<EventDetailsData.EventConditionsData> _eventConditions;

            private System.Nullable<bool> _useEventValue;

            /// <summary>List of event conditions.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("eventConditions")]
            public virtual System.Collections.Generic.IList<EventDetailsData.EventConditionsData> EventConditions
            {
                get
                {
                    return this._eventConditions;
                }
                set
                {
                    this._eventConditions = value;
                }
            }

            /// <summary>Determines if the event value should be used as the value for this goal.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("useEventValue")]
            public virtual System.Nullable<bool> UseEventValue
            {
                get
                {
                    return this._useEventValue;
                }
                set
                {
                    this._useEventValue = value;
                }
            }

            public class EventConditionsData
            {

                private string _type;

                private string _matchType;

                private string _expression;

                private string _comparisonType;

                private string _comparisonValue;

                /// <summary>Type of this event condition. Possible values are CATEGORY, ACTION, LABEL, or VALUE.</summary>
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

                /// <summary>Type of the match to be performed. Possible values are REGEXP, BEGINS_WITH, or EXACT.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("matchType")]
                public virtual string MatchType
                {
                    get
                    {
                        return this._matchType;
                    }
                    set
                    {
                        this._matchType = value;
                    }
                }

                /// <summary>Expression used for this match.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("expression")]
                public virtual string Expression
                {
                    get
                    {
                        return this._expression;
                    }
                    set
                    {
                        this._expression = value;
                    }
                }

                /// <summary>Type of comparison. Possible values are LESS_THAN, GREATER_THAN or EQUAL.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("comparisonType")]
                public virtual string ComparisonType
                {
                    get
                    {
                        return this._comparisonType;
                    }
                    set
                    {
                        this._comparisonType = value;
                    }
                }

                /// <summary>Value used for this comparison.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("comparisonValue")]
                public virtual string ComparisonValue
                {
                    get
                    {
                        return this._comparisonValue;
                    }
                    set
                    {
                        this._comparisonValue = value;
                    }
                }
            }
        }

        /// <summary>Parent link for a goal. Points to the profile to which this goal belongs.</summary>
        public class ParentLinkData
        {

            private string _href;

            private string _type;

            /// <summary>Link to the profile to which this goal belongs.</summary>
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

            /// <summary>Value is &quot;analytics#profile&quot;.</summary>
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
