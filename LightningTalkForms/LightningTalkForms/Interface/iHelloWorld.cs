using LightningTalkForms.Interface;
[assembly: Xamarin.Forms.Dependency(typeof(iHelloWorld))]
namespace LightningTalkForms.Interface
{
    public interface iHelloWorld
    {
        string GetHelloFromDevice();
    }
}
