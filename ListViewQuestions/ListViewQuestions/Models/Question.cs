using System;
using SQLite;

namespace ListViewQuestions
{
    public class Question
    {

        public Question() { }

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        //public string Image { get; set; }
        public string Text { get; set; }
        public string Answer { get; set; }
        //public bool correct { get; set; }

        //public Question(string Image, string Text, string Answer)
        //{
        //    this.Image = Image;
        //    this.Text = Text;
        //    this.Answer = Answer;
        //    this.correct = false;
        //}

        public Question(string Text, string Answer)
        {
            this.Text = Text;
            this.Answer = Answer;
        }
    }
}
