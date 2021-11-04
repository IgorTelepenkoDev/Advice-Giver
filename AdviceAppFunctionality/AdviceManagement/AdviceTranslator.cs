using System.Collections.Generic;

namespace AdviceAppFunctionality.AdviceManagement
{
    public class AdviceTranslator
    {
        public string TranslateAdvice(string advice, string baseLanguageSymb, string targetLanguageSymb)
        {
            var apiCaller = new ApiCallsController();

            var adviceFunctionalityHelper = new AdviceHelpFunctionalityProvider();
            var adviceTranslatorUrl = adviceFunctionalityHelper.GetAdviceTranslatorUrl();

            if (adviceTranslatorUrl == null)
                return null;

            var translatedAdviceJson = apiCaller.HttpPostRequest(adviceTranslatorUrl, 
                GetTranslateRequestContent(advice, baseLanguageSymb, targetLanguageSymb));
            return adviceFunctionalityHelper.ParseJsonTranslatedAdvice(translatedAdviceJson);
        }

        private IEnumerable<KeyValuePair<string, string>> GetTranslateRequestContent
            (string text, string baseLanguageSymbol, string targetLanguageSymbol)
        {
            var translateRequestContent = new Dictionary<string, string>()
            {
                {"q", text},
                {"source", baseLanguageSymbol},
                {"target", targetLanguageSymbol}
            };

            return translateRequestContent;
        }
    }
}
