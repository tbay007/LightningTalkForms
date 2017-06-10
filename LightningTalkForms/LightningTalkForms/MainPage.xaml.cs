using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LightningTalkForms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            string GetHelloWorld = Dependency.PlatformDependency.GetHelloFromDevice();
            numberText.Keyboard = Keyboard.Numeric; 
        }
    }
}
