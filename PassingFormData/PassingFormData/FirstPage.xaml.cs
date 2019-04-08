using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PassingFormData
{
    public partial class FirstPage : ContentPage
    {
        DateTime date = DateTime.Now;
        string dateString;

        public FirstPage()
        {
            InitializeComponent();
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
                Age = Int32.Parse(_age.Text),
                DateAdded = dateString
            };

            var secondPage = new SecondPage();
            secondPage.BindingContext = person;
            await Navigation.PushAsync(secondPage);
        }
    }
}
