namespace Google.Apis.Analytics.v3.Data
{
    /// <summary>JSON template for an Analytics custom data source.</summary>
    public class CustomDataSource
    {

        private string _kind;

        private string _description;

        private string _created;

        private System.Collections.Generic.IList<string> _profilesLinked;

        private string _updated;

        private string _name;

        private CustomDataSource.ChildLinkData _childLink;

        private string _webPropertyId;

        private CustomDataSource.ParentLinkData _parentLink;

        private string _id;

        private string _selfLink;

        private string _accountId;

        /// <summary>Resource type for Analytics custom data source.</summary>
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

        /// <summary>Description of custom data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }

        /// <summary>Time this custom data source was created.</summary>
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

        [Newtonsoft.Json.JsonPropertyAttribute("profilesLinked")]
        public virtual System.Collections.Generic.IList<string> ProfilesLinked
        {
            get
            {
                return this._profilesLinked;
            }
            set
            {
                this._profilesLinked = value;
            }
        }

        /// <summary>Time this custom data source was last modified.</summary>
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

        /// <summary>Name of this custom data source.</summary>
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

        /// <summary>Child link for this custom data source. Points to the list of daily uploads for this custom data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("childLink")]
        public virtual CustomDataSource.ChildLinkData ChildLink
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

        /// <summary>Web property ID of the form UA-XXXXX-YY to which this custom data source belongs.</summary>
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

        /// <summary>Parent link for this custom data source. Points to the web property to which this custom data source belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentLink")]
        public virtual CustomDataSource.ParentLinkData ParentLink
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

        /// <summary>Custom data source ID.</summary>
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

        /// <summary>Link for this Analytics custom data source.</summary>
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

        /// <summary>Account ID to which this custom data source belongs.</summary>
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

        /// <summary>Child link for this custom data source. Points to the list of daily uploads for this custom data source.</summary>
        public class ChildLinkData
        {

            private string _href;

            private string _type;

            /// <summary>Link to the list of daily uploads for this custom data source.</summary>
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

            /// <summary>Value is &quot;analytics#dailyUploads&quot;.</summary>
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

        /// <summary>Parent link for this custom data source. Points to the web property to which this custom data source belongs.</summary>
        public class ParentLinkData
        {

            private string _href;

            private string _type;

            /// <summary>Link to the web property to which this custom data source belongs.</summary>
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
