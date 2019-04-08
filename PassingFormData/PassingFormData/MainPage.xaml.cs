using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PassingFormData
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        DateTime date;
        string dateString;
        //public MainPage()
        public MainPage(DateTime date)
        {
            InitializeComponent();
            this.date = date;
            this.dateString = date.ToString("u");
            //The MainPage instance receives the data through a constructor parameter, as shown in the following code example:
            dateLabel.Text = date.ToString("u");
        }

        async void OnNavigateButtonClicked(object sender, EventArgs e)
        {
            var person = new Person
            {
                //Name = "André Araujo",
                //Age = 36
                Name = _name.Text,
                //Age = Int32.Parse(_age.ToString()),
                //DateAdded = dateString
            };

            var secondPage = new SecondPage();
            secondPage.BindingContext = person;
            await Navigation.PushAsync(secondPage);
        }
    }
}
