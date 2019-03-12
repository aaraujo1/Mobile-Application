using System;
using System.Collections.Generic;

namespace PersonalityQuiz
{
    public class Answer
    {
        public Answer()
        {

        }

        //public int AnswerID { private set; get; }
        public string AnswerText {  set; get; }
        public House House {  set; get; }

        public static IEnumerable<Answer> AllAnswers { private set; get; }




    }

}
