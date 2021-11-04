using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace AdviceAppFunctionality.AdviceManagement
{
    internal class NewAdviceJsonContentTemplate
    {
        public AdviceJsonInternalContentTemplate slip { get; set; }
    }

    internal class AdviceJsonInternalContentTemplate
    {
        public int id { get; set; }
        public string advice { get; set; }
    }

    internal class TranslatedAdviceJsonContentTemplate
    {
        public string translatedText { get; set; }
    }

    internal class AdviceHelpFunctionalityProvider
    {
        private const string ConfigFileName = "config.ini";
        private const string ConfigAdviceSection = "advice_source";
        private const string ConfigTranslateSection = "translate_source";
        private const string ConfigParamUrlAddress = "url";

        public string GetAdviceGeneratorUrl()
        {
            var configFilePath = GetConfigFilePath();
            if (configFilePath != null)
            {
                var configReceiver = new ConfigReader(configFilePath, ConfigAdviceSection);
                return configReceiver.GetValue(ConfigParamUrlAddress);
            }

            return null;
        }

        public string GetAdviceTranslatorUrl()
        {
            var configFilePath = GetConfigFilePath();
            if (configFilePath != null)
            {
                var configReceiver = new ConfigReader(configFilePath, ConfigTranslateSection);
                return configReceiver.GetValue(ConfigParamUrlAddress);
            }

            return null;
        }

        public Dictionary<int, string> ParseJsonAdvice(string adviceJson)
        {
            try
            {
                var deserializedAdviceData = JsonConvert.DeserializeObject<NewAdviceJsonContentTemplate>(adviceJson);
                int id = deserializedAdviceData.slip.id;
                string advice = deserializedAdviceData.slip.advice;

                return new Dictionary<int, string>() {{id, advice}};
            }
            catch (NullReferenceException)
            {
                return null;
            }
        }

        public string ParseJsonTranslatedAdvice(string translatedAdviceJson)
        {
            try
            {
                var deserializedTranslatedAdviceData = 
                    JsonConvert.DeserializeObject<TranslatedAdviceJsonContentTemplate>(translatedAdviceJson);
                string translatedResult = deserializedTranslatedAdviceData.translatedText;

                return translatedResult;
            }
            catch (NullReferenceException)
            {
                return null;
            }
        }

        // Config file should be located in the solution directory
        private string GetConfigFilePath()
        {
            try
            {
                string startupPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, ConfigFileName);
                return startupPath;
            }
            catch   // During logging specific exceptions might be described
            {
                return null;
            }
            
        }
    }
}
