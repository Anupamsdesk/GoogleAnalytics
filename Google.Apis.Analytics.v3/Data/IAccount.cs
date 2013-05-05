namespace Google.Apis.Analytics.v3.Data
{
    public interface IAccount
    {
        /// <summary>Resource type for Analytics account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        string Kind { get; set; }

        /// <summary>Account name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        string Name { get; set; }

        /// <summary>Time the account was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("created")]
        string Created { get; set; }

        /// <summary>Time the account was last modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updated")]
        string Updated { get; set; }

        /// <summary>Child link for an account entry. Points to the list of web properties for this account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("childLink")]
        Account.ChildLinkData ChildLink { get; set; }

        /// <summary>Account ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        string Id { get; set; }

        /// <summary>Link for this account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        string SelfLink { get; set; }
    }
}