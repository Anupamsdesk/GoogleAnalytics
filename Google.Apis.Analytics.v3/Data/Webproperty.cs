namespace Google.Apis.Analytics.v3.Data
{
    /// <summary>JSON template for an Analytics web property.</summary>
    public class Webproperty
    {

        private string _kind;

        private string _name;

        private string _created;

        private string _updated;

        private string _websiteUrl;

        private string _internalWebPropertyId;

        private Webproperty.ChildLinkData _childLink;

        private Webproperty.ParentLinkData _parentLink;

        private string _id;

        private string _selfLink;

        private string _accountId;

        /// <summary>Resource type for Analytics WebProperty.</summary>
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

        /// <summary>Name of this web property.</summary>
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

        /// <summary>Time this web property was created.</summary>
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

        /// <summary>Time this web property was last modified.</summary>
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

        /// <summary>Website url for this web property.</summary>
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

        /// <summary>Internal ID for this web property.</summary>
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

        /// <summary>Child link for this web property. Points to the list of profiles for this web property.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("childLink")]
        public virtual Webproperty.ChildLinkData ChildLink
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

        /// <summary>Parent link for this web property. Points to the account to which this web property belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentLink")]
        public virtual Webproperty.ParentLinkData ParentLink
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

        /// <summary>Web property ID of the form UA-XXXXX-YY.</summary>
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

        /// <summary>Link for this web property.</summary>
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

        /// <summary>Account ID to which this web property belongs.</summary>
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

        /// <summary>Child link for this web property. Points to the list of profiles for this web property.</summary>
        public class ChildLinkData
        {

            private string _href;

            private string _type;

            /// <summary>Link to the list of profiles for this web property.</summary>
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

            /// <summary>Type of the parent link. Its value is &quot;analytics#profiles&quot;.</summary>
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

        /// <summary>Parent link for this web property. Points to the account to which this web property belongs.</summary>
        public class ParentLinkData
        {

            private string _href;

            private string _type;

            /// <summary>Link to the account for this web property.</summary>
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

            /// <summary>Type of the parent link. Its value is &quot;analytics#account&quot;.</summary>
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
