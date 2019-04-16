using System;
using SQLite;
namespace FlashCard
{
    public class Card
    {
        public Card()
        {
        }

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Image { get; set; }
        public string Text { get; set; }
        public string Answer { get; set; }
        public bool correct { get; set; }

        public Card(int ID, string Image, string Text, string Answer)
        {
            this.ID = ID;
            this.Image = Image;
            this.Text = Text;
            this.Answer = Answer;
            this.correct = false;
        }
    }
}
