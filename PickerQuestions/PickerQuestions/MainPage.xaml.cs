using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PickerQuestions
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {

        public List<Question> Questions = new List<Question>()
        {
            new Question("duck", "Duck", "Ente"),
            new Question("squirrel", "Squirrel", "Eichhörnchen"),
            new Question("cow", "Cow", "Kuh"),
            new Question("chicken", "Chicken", "Hähnchen")
        };


        public MainPage()
        {
            InitializeComponent();

            picker.ItemsSource = Questions;
        }
    }
}
