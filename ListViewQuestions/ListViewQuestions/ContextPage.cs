using System;

using Xamarin.Forms;
using System.Diagnostics;
using System.Collections.Generic;

namespace ListViewQuestions
{
    public class ContextPage : ContentPage
    {
        public List<Question> questions = new List<Question>()
        {
            new Question("Duck", "Ente"),
            new Question("Squirrel", "Eichhörnchen"),
            new Question("Cow", "Kuh"),
            new Question("Chicken", "Hähnchen")
        };

        public ContextPage()
        {
            var listView = new ListView();



            //listView.ItemsSource = new[] { "alpha", "beta", "gamma", "delta" };
            listView.ItemsSource = questions;
            listView.ItemTemplate = new DataTemplate(typeof(ContextCell)); // has context actions defined

            // Using ItemTapped
            listView.ItemTapped += async (sender, e) => {
                Debug.WriteLine("Tapped: " + e.Item);
                await DisplayAlert("Tapped", 
                    questions.Find(x => x.Text == e.Item.ToString()).Answer,

                     "OK");
                ((ListView)sender).SelectedItem = null; // de-select the row
            };

            Padding = new Thickness(0, 20, 0, 0);
            Content = listView;
        }
    }
}

