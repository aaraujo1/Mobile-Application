using System;
using System.Collections.Generic;

namespace PickerQuestions.Models
{
    public class QuestionData
    {
        public static IList<Question> Questions { get; private set; }

        static QuestionData()
        {
            Questions = new List<Question>();

            Questions.Add(new Question("duck", "Duck", "Ente"));

            Questions.Add(new Question("squirrel", "Squirrel", "Eichhörnchen"));

            Questions.Add(new Question("cow", "Cow", "Kuh"));

            Questions.Add(new Question("chicken", "Chicken", "Hähnchen"));
        
        }
    }
}
