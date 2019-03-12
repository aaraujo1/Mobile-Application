using System;
using System.Collections.Generic;

namespace PersonalityQuiz
{
    public class Question
    {
        public Question()
        {
        }

        public int QuestionID { set; get; }
        public string QuestionText { private set; get; }
        //public string Image { private set; get; }
        public List<Answer> Answers { private set; get; }


        public static IEnumerable<Question> AllQuestions { private set; get; }


        //singleton
        static Question()
        {
            List<Question> questions = new List<Question>();
            //List<Answer> answers = new List<Answer>();

            {
                questions.Add(new Question
                {
                    QuestionID = 1,
                    QuestionText = "What best describes you?",
                    Answers = new List<Answer>() {
                        new Answer {AnswerText="Good",House=House.Hufflepuff },
                        new Answer {AnswerText="Great",House=House.Slytherin },
                        new Answer {AnswerText="Wise",House=House.Ravenclaw },
                        new Answer {AnswerText="Bold",House=House.Gryffindor },
                    },


                });
            }

            questions.Add(new Question
            {
                QuestionID = 2,
                QuestionText = "What is your worst Quality?",
                Answers = new List<Answer>() {
                        new Answer {AnswerText="Selfish",House=House.Hufflepuff },
                        new Answer {AnswerText="Ordinary",House=House.Slytherin },
                        new Answer {AnswerText="Ignorant",House=House.Ravenclaw },
                        new Answer {AnswerText="Cowardly",House=House.Gryffindor },
                    },
            });

            questions.Add(new Question
            {
                QuestionID = 3,
                QuestionText = "What do you value most?",
                Answers = new List<Answer>() {
                        new Answer {AnswerText="Love",House=House.Hufflepuff },
                        new Answer {AnswerText="Power",House=House.Slytherin },
                        new Answer {AnswerText="Wisdom",House=House.Ravenclaw },
                        new Answer {AnswerText="Glory",House=House.Gryffindor },
                    },
            });

            questions.Add(new Question
            {
                QuestionID = 4,
                QuestionText = "Which instrument excites you most?",
                Answers = new List<Answer>() {
                        new Answer {AnswerText="Trumpet",House=House.Hufflepuff },
                        new Answer {AnswerText="Violin",House=House.Slytherin },
                        new Answer {AnswerText="Piano",House=House.Ravenclaw },
                        new Answer {AnswerText="Drums",House=House.Gryffindor },
                    },
            });

            AllQuestions = questions;
        }
    }

}
