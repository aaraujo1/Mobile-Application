using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MorseCode
{
    public partial class MainPage : ContentPage
    {
        //Outside constructor
        IDictionary<string, string> morse = new Dictionary<string, string>();


        string Entry = "";
        string Letter = "";

        public MainPage()
        {
            InitializeComponent();

            //Inside constructor
            morse.Add(".-", "A");
            morse.Add("-...", "B");
            morse.Add("-.-.", "C");
            morse.Add("-..", "D");
            morse.Add(".", "E");
            morse.Add("..-.", "F");
            morse.Add("--.", "G");
            morse.Add("....", "H");
            morse.Add("..", "I");
            morse.Add(".---", "J");
            morse.Add("-.-", "K");
            morse.Add(".-..", "L");
            morse.Add("--", "M");
            morse.Add("-.", "N");
            morse.Add("---", "O");
            morse.Add(".--.", "P");
            morse.Add("--.-", "Q");
            morse.Add(".-.", "R");
            morse.Add("...", "S");
            morse.Add("-", "T");
            morse.Add("..-", "U");
            morse.Add("...-", "V");
            morse.Add("-..-", "X");
            morse.Add("-.--", "Y");
            morse.Add("--..", "Z");
            morse.Add(".----", "1");
            morse.Add("..---", "2");
            morse.Add("...--", "3");
            morse.Add("....-", "4");
            morse.Add(".....", "5");
            morse.Add("-....", "6");
            morse.Add("--...", "7");
            morse.Add("---..", "8");
            morse.Add("----.", "9");
            morse.Add("-----", "0");


        }

        void OnDotButtonClicked(object sender, EventArgs e)
        {
            Entry += ".";
            _labelMorse.Text += ".";
        }

        void OnDashButtonClicked(object sender, EventArgs e)
        {
            Entry += "-";
            _labelMorse.Text += "-";
        }

        void OnSpaceButtonClicked(object sender, EventArgs e)
        {
            //if hit twice, new word
            if (Entry == "")
            {
                _labelMorse.Text += " ";
                _labelAlpha.Text += " ";

            }
            else
            {
                //if not found
                try
                {
                    //convert letter
                    //find entry in dictionary
                    Letter = morse[Entry];
                    //reset Entry
                    Entry = "";
                    //add to label
                    _labelAlpha.Text += Letter;
                    _labelError.Text = "";

                }
                catch(Exception ex)
                {
                    //_labelError.Text = ex.ToString();

                    //alert user
                    _labelError.Text = "Not a valid morse code";

                    //var morseString = _labelMorse.Text

                    //remove bad dots and dashes
                    _labelMorse.Text = _labelMorse.Text.Remove(Entry.Length-1);

                    //reset Entry
                    Entry = "";
                }


            }
        }






    }
}
