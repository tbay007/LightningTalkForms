using System;
using System.Collections.Generic;
using System.Text;
using LightningTalkForms.Interface;

[assembly: Xamarin.Forms.Dependency(typeof(LightningTalkForms.Interface.iHelloWorld))]
namespace LightningTalkForms.iOS
{
    public class HelloWorldHook : iHelloWorld
    {
        public HelloWorldHook() { }
        public string GetHelloFromDevice()
        {
            return "Hello From the android device";
        }
    }
}
