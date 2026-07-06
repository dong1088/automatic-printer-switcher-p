using System.Text.Json.Serialization;

namespace PrinterSwitcher
{
    public class PSProcess
    {
        private string mProcessName = string.Empty;
        private bool mISMDIContainer = false;

        [JsonInclude]
        public string ProcessName
        {
            get { return mProcessName; }
            private set { mProcessName = value; }
        }

        [JsonInclude]
        public bool ISMDIContainer
        {
            get { return mISMDIContainer; }
            private set { mISMDIContainer = value; }
        }

        [JsonInclude]
        public string MappedPrinter
        {
            get { return mMappedPrinter; }
            set { mMappedPrinter = value; }
        }

        private string mMappedPrinter = string.Empty;

        /// <summary>
        /// For deserialization only
        /// </summary>
        public PSProcess()
        {
        }

        public PSProcess(string processName, bool mdiContainer)
        {
            mProcessName = processName;
            mISMDIContainer = mdiContainer;
        }
    }
}