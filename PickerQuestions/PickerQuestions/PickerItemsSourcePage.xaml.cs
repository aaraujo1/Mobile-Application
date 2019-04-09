using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PickerQuestions
{
    public partial class PickerItemsSourcePage : ContentPage
    {
        public List<Question> Questions = new List<Question>()
        {
            new Question("duck", "Duck", "Ente"),
            new Question("squirrel", "Squirrel", "Eichhörnchen"),
            new Question("cow", "Cow", "Kuh"),
            new Question("chicken", "Chicken", "Hähnchen")
        };

        public PickerItemsSourcePage()
        {
            InitializeComponent();


        }
    }
}
