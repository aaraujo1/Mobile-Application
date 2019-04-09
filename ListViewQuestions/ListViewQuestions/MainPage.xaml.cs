using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Diagnostics;

namespace ListViewQuestions
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        ObservableCollection<string> items;

        public List<Question> questions = new List<Question>()
        {
            new Question("Duck", "Ente"),
            new Question("Squirrel", "Eichhörnchen"),
            new Question("Cow", "Kuh"),
            new Question("Chicken", "Hähnchen")
        };

        ObservableCollection<Question> questionCollection = new ObservableCollection<Question>
        {
            new Question("Duck", "Ente"),
            new Question("Squirrel", "Eichhörnchen"),
            new Question("Cow", "Kuh"),
            new Question("Chicken", "Hähnchen")
        };


        public MainPage()
        {
            InitializeComponent();



            //items = new ObservableCollection<string> { "alpha", "beta", "gamma", "delta", "epsilon" };
            items = new ObservableCollection<string>();
            foreach(Question q in questions){
                items.Add(q.Text);
            }

            //listView.ItemsSource = items;
            listView.ItemsSource = questionCollection;
            //listView.SetBinding (ListView.ItemsSourceProperty, new Binding ("Question"));
            //listView.BindingContext = items;

        }

        public void OnItemSelected (object sender, SelectedItemChangedEventArgs e) {
            if (e.SelectedItem == null) return; // has been set to null, do not 'process' tapped event
            DisplayAlert("Tapped",
                 questions.Find(x => x.Text == e.SelectedItem.ToString()).Answer,
                  "OK");
            ((ListView)sender).SelectedItem = null; // de-select the row
        }

        public void OnMore (object sender, EventArgs e) {
            var mi = ((MenuItem)sender);
            DisplayAlert("More Context Action", mi.CommandParameter + " more context action", "OK");
        }

        public void OnDelete (object sender, EventArgs e) {
            var mi = ((MenuItem)sender);
            //DisplayAlert("Delete Context Action", mi.CommandParameter + " delete context action", "OK");

            Debug.WriteLine ("delete " + mi.CommandParameter.ToString ());
            items.Remove (mi.CommandParameter.ToString());
        }
    }
}
