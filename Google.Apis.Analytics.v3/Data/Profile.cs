namespace Google.Apis.Analytics.v3.Data
{
    /// <summary>JSON template for an Analytics profile.</summary>
    public class Profile : IProfile
    {

        private string _defaultPage;
        private string _kind;
        private string _excludeQueryParameters;
        private string _name;
        private string _created;
        private string _webPropertyId;
        private string _updated;
        private string _siteSearchQueryParameters;
        private string _websiteUrl;
        private string _currency;
        private string _internalWebPropertyId;
        private Profile.ChildLinkData _childLink;
        private System.Nullable<bool> _eCommerceTracking;
        private string _timezone;
        private string _siteSearchCategoryParameters;
        private Profile.ParentLinkData _parentLink;
        private string _type;
        private string _id;
        private string _selfLink;
        private string _accountId;

        /// <summary>Default page for this profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultPage")]
        public virtual string DefaultPage
        {
            get
            {
                return this._defaultPage;
            }
            set
            {
                this._defaultPage = value;
            }
        }

        /// <summary>Resource type for Analytics profile.</summary>
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

        /// <summary>The query parameters that are excluded from this profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludeQueryParameters")]
        public virtual string ExcludeQueryParameters
        {
            get
            {
                return this._excludeQueryParameters;
            }
            set
            {
                this._excludeQueryParameters = value;
            }
        }

        /// <summary>Name of this profile.</summary>
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

        /// <summary>Time this profile was created.</summary>
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

        /// <summary>Web property ID of the form UA-XXXXX-YY to which this profile belongs.</summary>
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

        /// <summary>Time this profile was last modified.</summary>
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

        /// <summary>The site search query parameters for this profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("siteSearchQueryParameters")]
        public virtual string SiteSearchQueryParameters
        {
            get
            {
                return this._siteSearchQueryParameters;
            }
            set
            {
                this._siteSearchQueryParameters = value;
            }
        }

        /// <summary>Website URL for this profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("websiteUrl")]
        public virtual string WebsiteUrl
        {
            get
            {
                return this._websiteUrl;
            }
            set
            {
                this._websiteUrl = value;
            }
        }

        /// <summary>The currency type associated with this profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currency")]
        public virtual string Currency
        {
            get
            {
                return this._currency;
            }
            set
            {
                this._currency = value;
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

        /// <summary>Child link for this profile. Points to the list of goals for this profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("childLink")]
        public virtual Profile.ChildLinkData ChildLink
        {
            get
            {
                return this._childLink;
            }
            set
            {
                this._childLink = value;
            }
        }

        /// <summary>E-commerce tracking parameter for this profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eCommerceTracking")]
        public virtual System.Nullable<bool> ECommerceTracking
        {
            get
            {
                return this._eCommerceTracking;
            }
            set
            {
                this._eCommerceTracking = value;
            }
        }

        /// <summary>Time zone for which this profile has been configured.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timezone")]
        public virtual string Timezone
        {
            get
            {
                return this._timezone;
            }
            set
            {
                this._timezone = value;
            }
        }

        /// <summary>Site search category parameters for this profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("siteSearchCategoryParameters")]
        public virtual string SiteSearchCategoryParameters
        {
            get
            {
                return this._siteSearchCategoryParameters;
            }
            set
            {
                this._siteSearchCategoryParameters = value;
            }
        }

        /// <summary>Parent link for this profile. Points to the web property to which this profile belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentLink")]
        public virtual Profile.ParentLinkData ParentLink
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

        /// <summary>Profile type. Supported types: WEB or APP.</summary>
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

        /// <summary>Profile ID.</summary>
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

        /// <summary>Link for this profile.</summary>
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

        /// <summary>Child link for this profile. Points to the list of goals for this profile.</summary>
        public class ChildLinkData
        {

            private string _href;

            private string _type;

            /// <summary>Link to the list of goals for this profile.</summary>
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

            /// <summary>Value is &quot;analytics#goals&quot;.</summary>
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

        /// <summary>Parent link for this profile. Points to the web property to which this profile belongs.</summary>
        public class ParentLinkData
        {

            private string _href;

            private string _type;

            /// <summary>Link to the web property to which this profile belongs.</summary>
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

            /// <summary>Value is &quot;analytics#webproperty&quot;.</summary>
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
