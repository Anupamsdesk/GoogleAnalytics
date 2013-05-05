namespace Google.Apis.Analytics.v3.Data
{
    /// <summary>JSON template for Analytics account entry.</summary>
    public class Account : IAccount
    {

        private string _kind;
        private string _name;
        private string _created;
        private string _updated;
        private Account.ChildLinkData _childLink;
        private string _id;
        private string _selfLink;
        
        /// <summary>Resource type for Analytics account.</summary>
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

        /// <summary>Account name.</summary>
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

        /// <summary>Time the account was created.</summary>
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

        /// <summary>Time the account was last modified.</summary>
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

        /// <summary>Child link for an account entry. Points to the list of web properties for this account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("childLink")]
        public virtual Account.ChildLinkData ChildLink
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

        /// <summary>Account ID.</summary>
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

        /// <summary>Link for this account.</summary>
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

        /// <summary>Child link for an account entry. Points to the list of web properties for this account.</summary>
        public class ChildLinkData
        {

            private string _href;

            private string _type;

            /// <summary>Link to the list of web properties for this account.</summary>
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

            /// <summary>Type of the child link. Its value is &quot;analytics#webproperties&quot;.</summary>
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
