using System.Text.Json;

namespace PrinterSwitcher
{
    class PSDB
    {
        public string mAppDataDir = string.Empty;
        public string mMapFilePath = string.Empty;

        private static readonly JsonSerializerOptions JsonOptions = new JsonSerializerOptions
        {
            WriteIndented = true,
            IncludeFields = true
        };

        public PSDB()
        {
            mAppDataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\APS";
            mMapFilePath = mAppDataDir + @"\processPrinterMap.json";
        }

        public bool saveProcesses(PSProcessCollection collection)
        {
            try
            {
                if (!Directory.Exists(mAppDataDir))
                {
                    Directory.CreateDirectory(mAppDataDir);
                }

                string json = JsonSerializer.Serialize(collection, JsonOptions);
                File.WriteAllText(mMapFilePath, json);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error saving mapping to disk",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }

        public PSProcessCollection loadProcesses()
        {
            try
            {
                // Try new JSON format first
                if (File.Exists(mMapFilePath))
                {
                    string json = File.ReadAllText(mMapFilePath);
                    var result = JsonSerializer.Deserialize<PSProcessCollection>(json, JsonOptions);
                    if (result != null)
                        return result;
                }

                // Fallback: try old binary .dat file for backward compatibility
                string oldPath = mAppDataDir + @"\processPrinterMap.dat";
                if (File.Exists(oldPath))
                {
                    return LoadLegacyBinaryData(oldPath);
                }

                return null;
            }
            catch
            {
                // Try legacy format as fallback
                string oldPath = mAppDataDir + @"\processPrinterMap.dat";
                if (File.Exists(oldPath))
                {
                    try { return LoadLegacyBinaryData(oldPath); }
                    catch { }
                }
                return null;
            }
        }

        /// <summary>
        /// Load data from old binary-format .dat file for backward compatibility.
        /// BinaryFormatter is disabled in .NET 10+ runtime config, so this may not load successfully.
        /// In that case, we return null and the user's old mappings are gracefully reset.
        /// </summary>
        #nullable enable
        private static PSProcessCollection? LoadLegacyBinaryData(string oldPath)
        {
            try
            {
#pragma warning disable SYSLIB0011 // BinaryFormatter is obsolete
                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                using var ms = new MemoryStream(File.ReadAllBytes(oldPath));
                var result = formatter.Deserialize(ms) as PSProcessCollection;
                return result;
#pragma warning restore SYSLIB0011
            }
            catch
            {
                return null;
            }
        }
    }
}