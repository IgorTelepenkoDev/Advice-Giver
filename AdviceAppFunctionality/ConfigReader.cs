using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace AdviceAppFunctionality
{
    // Reads configuration from standard format of '.ini' files
    class ConfigReader
    {
        Dictionary<string, string> confValues;

        public ConfigReader(string configFilePath, string section = null)
        {
            var sectionTitle = $"[{section}]";
            var allConfigData = File.ReadAllLines(configFilePath);
            var wholeSectionData = new List<string>();

            if (section != null && allConfigData.Contains(sectionTitle))
            {
                bool isSectionFound = false;
                foreach (var line in allConfigData)
                {
                    if(line.Length != 0)
                        if (line[0] == Convert.ToChar("[") && line[line.Length - 1] == Convert.ToChar("]")) // if there is another section started
                            isSectionFound = false;

                    if (isSectionFound)
                        wholeSectionData.Add(line);

                    if (line == sectionTitle)
                        isSectionFound = true;
                }
            }
            else wholeSectionData = allConfigData.ToList<string>();

            confValues = wholeSectionData
                .Where(line => (!String.IsNullOrWhiteSpace(line) && !line.StartsWith("#")))
                .Select(line => line.Split(new char[] { '=' }, 2, 0))
                .ToDictionary(parts => parts[0].Trim(), 
                    parts => parts.Length > 1 ? parts[1].Trim() : null);
        }

        public string GetValue(string keyName)
        {
            if (confValues != null && confValues.ContainsKey(keyName))
                return confValues[keyName];

            return null;
        }
    }
}
