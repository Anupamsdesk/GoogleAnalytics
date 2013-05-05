namespace Google.Apis.Analytics.v3.Data
{


    /// <summary>JSON template for an Analytics advanced segment.</summary>
    public class Segment
    {

        private string _definition;

        private string _kind;

        private string _segmentId;

        private string _created;

        private string _updated;

        private string _id;

        private string _selfLink;

        private string _name;

        /// <summary>Advanced segment definition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("definition")]
        public virtual string Definition
        {
            get
            {
                return this._definition;
            }
            set
            {
                this._definition = value;
            }
        }

        /// <summary>Resource type for Analytics advanced segment.</summary>
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

        /// <summary>Segment ID. Can be used with the &apos;segment&apos; parameter in Data Feed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentId")]
        public virtual string SegmentId
        {
            get
            {
                return this._segmentId;
            }
            set
            {
                this._segmentId = value;
            }
        }

        /// <summary>Time the advanced segment was created.</summary>
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

        /// <summary>Time the advanced segment was last modified.</summary>
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

        /// <summary>Advanced segment ID.</summary>
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

        /// <summary>Link for this advanced segment.</summary>
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

        /// <summary>Advanced segment name.</summary>
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
