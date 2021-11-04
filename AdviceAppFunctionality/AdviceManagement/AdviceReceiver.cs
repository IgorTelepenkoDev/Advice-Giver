using System.Collections.Generic;

namespace AdviceAppFunctionality.AdviceManagement
{
    public class AdviceReceiver
    {
        public KeyValuePair<int,string> GetNewAdvice()
        {
            var apiCaller = new ApiCallsController();

            var adviceFunctionalityHelper = new AdviceHelpFunctionalityProvider();
            var adviceGeneratorUrl = adviceFunctionalityHelper.GetAdviceGeneratorUrl();

            if (adviceGeneratorUrl == null)
                return default;
            
            var newAdviceJson = apiCaller.HttpGetRelease(adviceGeneratorUrl);
            return adviceFunctionalityHelper.ParseJsonAdvice(newAdviceJson);
        }
    }
}
