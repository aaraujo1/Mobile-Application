using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PassingFormData
{
    public partial class App : Application
    {
        public App()
        {
            //InitializeComponent();

            //MainPage = new MainPage();


            //This code creates a MainPage instance, passing in the current date and time in ISO8601 format, 
            //which is wrapped in a NavigationPage instance.
            //MainPage = new NavigationPage(new MainPage(DateTime.Now));
            MainPage = new PassingFormData.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
