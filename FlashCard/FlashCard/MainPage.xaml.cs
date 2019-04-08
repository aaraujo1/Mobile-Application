using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FlashCard
{
    public partial class MainPage : ContentPage
    {

        public int CardNumber = 0;
        public int Loops = 0;

        public List<Card> cards = new List<Card>()
        {
            new Card("duck", "Duck", "Ente"),
            new Card("squirrel", "Squirrel", "Eichhörnchen"),
            new Card("cow", "Cow", "Kuh"),
            new Card("chicken", "Chicken", "Hähnchen")
        };



        public MainPage()
        {
            InitializeComponent();

            //set initial image and text
            _image.Source = cards.ElementAt(CardNumber).Image;
            _label.Text = cards.ElementAt(CardNumber).Text;

            //hide buttons
            ButtonCorrectButton.IsVisible = false;
            ButtonWrongButton.IsVisible = false;

        }

        //defining function OnSwiped
        void OnSwiped(object sender, SwipedEventArgs e)
        {
            //_label.Text = $"You swiped: {e.Direction.ToString()}";
            switch (e.Direction)
            {
                case SwipeDirection.Right:
                    // Handle the swipe
                    //_image.Source = cards.ElementAt(CardNumber).Image;
                    _label.Text = cards.ElementAt(CardNumber).Text;
                    ButtonCorrectButton.IsVisible = false;
                    ButtonWrongButton.IsVisible = false;

                    break;
                case SwipeDirection.Left:
                    // Handle the swipe
                    //_image.Source = "";
                    _label.Text = cards.ElementAt(CardNumber).Answer;
                    ButtonCorrectButton.IsVisible = true;
                    ButtonWrongButton.IsVisible = true;
                    break;
                
            }
        }

        void ButtonCorrect(object sender, SwipedEventArgs e)
        {
            //answered correctly
            cards.ElementAt(CardNumber).correct = true;

            if (CardNumber < cards.Count()-1)
            {
                //keep going
                CardNumber++;
                _image.Source = cards.ElementAt(CardNumber).Image;
                _label.Text = cards.ElementAt(CardNumber).Text;

                ButtonCorrectButton.IsVisible = false;
                ButtonWrongButton.IsVisible = false;
            }
            else
            {
                //redo wrong answers
                RedoWrong();
            }

        }

        void ButtonWrong(object sender, SwipedEventArgs e)
        {
            if (CardNumber < cards.Count()-1)
            {
                //keep going
                CardNumber++;
                _image.Source = cards.ElementAt(CardNumber).Image;
                _label.Text = cards.ElementAt(CardNumber).Text;

                ButtonCorrectButton.IsVisible = false;
                ButtonWrongButton.IsVisible = false;
            }
            else
            {
                //redo wrong answers
                RedoWrong();
            }
        }

        async void RedoWrong()
        {

            List<Card> cardsWrong = cards.Where(x => x.correct == false).ToList();

            if (cardsWrong.Any())
            {
                cards = cardsWrong;

                CardNumber = 0;
                Loops++;

                await DisplayAlert("You got some wrong!", "Card wrong: " + cards.Count(), "Try again");


                _image.Source = cards.ElementAt(CardNumber).Image;
                _label.Text = cards.ElementAt(CardNumber).Text;

                ButtonCorrectButton.IsVisible = false;
                ButtonWrongButton.IsVisible = false;

            }
            else
            {
                End();
            }
        }

        void End()
        {
            _image.IsVisible = false;
            _label.Text = $"Number of Loops: {Loops.ToString()}";
        }


    }
}
