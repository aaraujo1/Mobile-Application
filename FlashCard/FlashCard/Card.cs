using System;
namespace FlashCard
{
    public class Card
    {
        public Card()
        {
        }

        public string Image { get; set; }
        public string Text { get; set; }
        public string Answer { get; set; }
        public bool correct { get; set; }

        public Card(string Image, string Text, string Answer)
        {
            this.Image = Image;
            this.Text = Text;
            this.Answer = Answer;
            this.correct = false;
        }
    }
}
