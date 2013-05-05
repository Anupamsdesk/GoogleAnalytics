namespace Google.Apis.Analytics.v3.Data
{
    public interface IProfile
    {
        /// <summary>Default page for this profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultPage")]
        string DefaultPage { get; set; }

        /// <summary>Resource type for Analytics profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        string Kind { get; set; }

        /// <summary>The query parameters that are excluded from this profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludeQueryParameters")]
        string ExcludeQueryParameters { get; set; }

        /// <summary>Name of this profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        string Name { get; set; }

        /// <summary>Time this profile was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("created")]
        string Created { get; set; }

        /// <summary>Web property ID of the form UA-XXXXX-YY to which this profile belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webPropertyId")]
        string WebPropertyId { get; set; }

        /// <summary>Time this profile was last modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updated")]
        string Updated { get; set; }

        /// <summary>The site search query parameters for this profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("siteSearchQueryParameters")]
        string SiteSearchQueryParameters { get; set; }

        /// <summary>Website URL for this profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("websiteUrl")]
        string WebsiteUrl { get; set; }

        /// <summary>The currency type associated with this profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currency")]
        string Currency { get; set; }

        /// <summary>Internal ID for the web property to which this profile belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("internalWebPropertyId")]
        string InternalWebPropertyId { get; set; }

        /// <summary>Child link for this profile. Points to the list of goals for this profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("childLink")]
        Profile.ChildLinkData ChildLink { get; set; }

        /// <summary>E-commerce tracking parameter for this profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eCommerceTracking")]
        System.Nullable<bool> ECommerceTracking { get; set; }

        /// <summary>Time zone for which this profile has been configured.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timezone")]
        string Timezone { get; set; }

        /// <summary>Site search category parameters for this profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("siteSearchCategoryParameters")]
        string SiteSearchCategoryParameters { get; set; }

        /// <summary>Parent link for this profile. Points to the web property to which this profile belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentLink")]
        Profile.ParentLinkData ParentLink { get; set; }

        /// <summary>Profile type. Supported types: WEB or APP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        string Type { get; set; }

        /// <summary>Profile ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        string Id { get; set; }

        /// <summary>Link for this profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        string SelfLink { get; set; }

        /// <summary>Account ID to which this profile belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        string AccountId { get; set; }
    }
}