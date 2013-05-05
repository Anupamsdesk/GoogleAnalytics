namespace Google.Apis.Analytics.v3
{
    public partial class AnalyticsService
    {

        private const string Resource = "";

        private ManagementResource _management;

        private DataResource _data;

        private Google.Apis.Services.IClientService service
        {
            get
            {
                return this;
            }
        }

        public virtual ManagementResource Management
        {
            get
            {
                return this._management;
            }
        }

        public virtual DataResource Data
        {
            get
            {
                return this._data;
            }
        }
    }
}
