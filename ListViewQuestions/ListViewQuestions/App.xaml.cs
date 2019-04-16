using System;
using System.IO;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ListViewQuestions.Data;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ListViewQuestions
{
    public partial class App : Application
    {
        static QuestionDatabase database;

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        public static QuestionDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new QuestionDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TodoSQLite.db3"));
                }
                return database;
            }
        }

        public int ResumeAtTodoId { get; set; }


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
