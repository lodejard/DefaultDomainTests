using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomThing
{
    public class CustomAppDomainManager : AppDomainManager
    {
        public override void InitializeNewDomain(AppDomainSetup appDomainInfo)
        {
            appDomainInfo.ApplicationBase = appDomainInfo.ApplicationBase.Replace(
                "DefaultDomainTests\\bin", 
                "TotallyDifferentProject\\bin");

            appDomainInfo.ConfigurationFile = Path.Combine(
                appDomainInfo.ApplicationBase,
                "Another.config");

            base.InitializeNewDomain(appDomainInfo);
        }
    }
}
