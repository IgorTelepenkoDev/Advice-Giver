using System.Collections.Generic;

namespace AdviceAppFunctionality
{
    public class AdviceReceiver
    {
        public Dictionary<int,string> GetNewAdvice()
        {
            var apiCaller = new ApiCallsController();

            var adviceFunctionalityHelper = new AdviceHelpFunctionalityProvider();
            var adviceGeneratorUrl = adviceFunctionalityHelper.GetAdviceGeneratorUrl();

            if (adviceGeneratorUrl == null)
                return null;
            
            var newAdviceJson = apiCaller.HttpGetRelease(adviceGeneratorUrl);
            return adviceFunctionalityHelper.ParseJsonAdvice(newAdviceJson);
        }
    }
}
