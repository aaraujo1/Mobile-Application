using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PersonalityQuiz
{
    public partial class MainPage : ContentPage
    {
        int questionNumber = 0;
        List<House> values = new List<House>();

        public MainPage()
        {
            InitializeComponent();

            GetQuestionsAndAnswers(questionNumber);

        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            AddToList(btn.GetValue(HouseNameProperty).ToString());



            if (questionNumber < Question.AllQuestions.Count()-1)
            {
                questionNumber++;
                GetQuestionsAndAnswers(questionNumber);
            }
            else
            {
                //show answer
            }


            //Button btn = (Button)sender;


        }

        public void GetQuestionsAndAnswers(int i)
        {
            
            The_Question.Text = Question.AllQuestions.ElementAt(i).QuestionText;
            Answer0.Text = Question.AllQuestions.ElementAt(i).Answers[0].AnswerText;
            Answer1.Text = Question.AllQuestions.ElementAt(i).Answers[1].AnswerText;
            Answer2.Text = Question.AllQuestions.ElementAt(i).Answers[2].AnswerText;
            Answer3.Text = Question.AllQuestions.ElementAt(i).Answers[3].AnswerText;

            Answer0.SetValue(HouseNameProperty, Question.AllQuestions.ElementAt(i).Answers[0].House);
            Answer1.SetValue(HouseNameProperty, Question.AllQuestions.ElementAt(i).Answers[1].House);
            Answer2.SetValue(HouseNameProperty, Question.AllQuestions.ElementAt(i).Answers[2].House);
            Answer3.SetValue(HouseNameProperty, Question.AllQuestions.ElementAt(i).Answers[3].House);
        }

        public static readonly BindableProperty HouseNameProperty =
                BindableProperty.Create("HouseName", typeof(House), typeof(House), null);

        //public static readonly BindableProperty EventNameProperty = BindableProperty.Create("EventName", typeof(string), typeof(EventToCommandBehavior), null);
        /*
         * This creates a BindableProperty instance named EventName, of type string. 
         * The property is owned by the EventToCommandBehavior class, and has a default value of null. 
         * The naming convention for bindable properties is that the bindable property identifier must match the property name specified in the Create method, with "Property" appended to it. 
         * Therefore, in the example above, the bindable property identifier is EventNameProperty.
         * 
         * https://docs.microsoft.com/en-us/xamarin/xamarin-forms/xaml/bindable-properties
         */

        //public String Question(int i)
        //{

        //    String q = Question.AllQuestions.Where(x => x.QuestionID == i);
        //    return q;

        //}

        public void AddToList(House house)
        {
            values.Add(house);
        }

    }
}
