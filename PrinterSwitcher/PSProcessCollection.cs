using System.Text.Json.Serialization;

namespace PrinterSwitcher
{
    public class PSProcessCollection : Dictionary<string, PSProcess>
    {
        [JsonInclude]
        public string mSysDefPrinter = string.Empty;

        public PSProcessCollection() : base()
        {
        }
    }
}