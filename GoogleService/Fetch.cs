using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleService
{
    using Google.Apis.Analytics.v3;
    using Google.Apis.Analytics.v3.Data;
    using AppLogger;
    public class Fetch
    {


        public static void getQueryAnalyticsResult(
            string accessToken,
            string metrics,
            string dimensions,
            string startDate = "2013-04-01",
            string endDate = "2013-04-30",
            string profileId = "ga:70717743"
            )
        {


            var logger = new Logger("GoogleService.Fetch");
            var service = new AnalyticsService();


            //var response = service.Data.Ga.Get(profileId, startDate, endDate, metrics);
            var resource = service.Data.Ga.Get(profileId, startDate, endDate, metrics);
            resource.Dimensions = dimensions;
            resource.MaxResults = 10000;
            resource.StartIndex = 1;
            resource.Oauth_token = accessToken;
            GaData report =  resource.FetchSync();


            logger.Write(0, "Successfully fetched data with " + report.Rows + " rows.");



        }




    }
}
