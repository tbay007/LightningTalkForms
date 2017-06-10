using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using LightningTalkForms.Interface;
namespace LightningTalkForms.Dependency
{
    public class PlatformDependency
    {
        public static string GetHelloFromDevice()
        {
            if (Device.OS == TargetPlatform.iOS || Device.OS == TargetPlatform.Android)
            {
                var helloWorldHook = DependencyService.Get<iHelloWorld>();
                return helloWorldHook.GetHelloFromDevice();
            }
            return string.Empty;
        }
    }
}
