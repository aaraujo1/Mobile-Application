using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Xamarin.Forms;

namespace XamlSamples
{
    public partial class ColorTyper : ContentPage
    {
        public ColorTyper()
        {
            InitializeComponent();
        }


        void OnButtonClicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            _label.Text = sender.ToString();
            _theList.ItemsSource = Filter(btn.Text);
        }

        public IEnumerable<NamedColor> Filter(string s)
        {
            IEnumerable < NamedColor > f = NamedColor.All.Where(x => x.Color.R.ToString()[0].Equals(s));
            return f;

        }
    }
}
