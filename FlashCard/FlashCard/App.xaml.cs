using System;
using System.IO;
using FlashCard.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace FlashCard
{
    public partial class App : Application
    {
        static FlashCardDatabase database;

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        public static FlashCardDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new FlashCardDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CardSQLite.db3"));
                }
                return database;
            }
        }

        public int ResumeAtCardId { get; set; }


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
