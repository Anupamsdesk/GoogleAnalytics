namespace Google.Apis.Analytics.v3.Data
{
    public interface IDailyUploadAppend
    {
        /// <summary>Resource type for Analytics daily upload append.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        string Kind { get; set; }

        /// <summary>Custom data source Id to which this daily upload append belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customDataSourceId")]
        string CustomDataSourceId { get; set; }

        /// <summary>Append number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appendNumber")]
        System.Nullable<long> AppendNumber { get; set; }

        /// <summary>Web property Id of the form UA-XXXXX-YY to which this daily upload append belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webPropertyId")]
        string WebPropertyId { get; set; }

        /// <summary>Date associated with daily upload append.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        string Date { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("nextAppendLink")]
        string NextAppendLink { get; set; }

        /// <summary>Account Id to which this daily upload append belongs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        string AccountId { get; set; }

        string ETag { get; set; }
    }
}