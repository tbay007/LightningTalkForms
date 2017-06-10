using LightningTalkForms.Interface;

[assembly: Xamarin.Forms.Dependency(typeof(LightningTalkForms.Droid.HelloWorldHook))]
namespace LightningTalkForms.Droid
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