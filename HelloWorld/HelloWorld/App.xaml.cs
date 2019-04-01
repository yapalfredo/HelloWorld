using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace HelloWorld
{
    public partial class App : Application
    {
        public App()
        {                
            InitializeComponent();

            // MainPage = new GreetPage();
            MainPage = new StackLayout2();
        
        }


    }
}
