using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public abstract class QuestionBase
    {
        protected string body;
        protected double marks;
        Answers[] answerList;
        private Answers rightAnswer;

        public abstract string Header { get; }

        public double Marks
        {
            get { return marks; }
            set { marks = value; }
        }

        public string Body
        {
            get { return body; }
            set { body = value; }
        }

        public Answers RightAnswer
        {
            get { return rightAnswer; }
            set { rightAnswer = value; }
        }

        public Answers[] AnswerList
        {
            get { return answerList; }
            set { answerList = value; }

        }

        public Answers this[int id]
        {
            get
            {
                for (int i = 0; i < answerList.Length; i++)
                {
                    if (answerList[i].AnswerId == id)
                        return answerList[i];
                }
                return new Answers();
            }
        }


        public Answers this[string text]
        {
            get
            {
                for (int i = 0; i < answerList.Length; i++)
                {
                    if (answerList[i].AnswerText == text)
                        return answerList[i];
                }
                return new Answers();
            }
        }

        public QuestionBase(string _body, double _marks)
        {
            body = _body;
            marks = _marks;
        }



        public static QuestionBase[] CreateBaseQuestion(int size)
        {
            QuestionBase[] questions = new QuestionBase[size];

            for (int i = 0; i < questions?.Length; i++)
            {
                int questionType;
                do
                {
                    Console.WriteLine(
                        $"Please choose the type of question number {i + 1} " +
                        $"(1 for T/F Question, 2 for Choose one Question, 3 for MCQ"
                        );
                } while (!int.TryParse(Console.ReadLine(), out questionType) || questionType < 1 || questionType > 3);


                if (questionType == 1)
                {
                    Console.WriteLine($"the data of T/F Question Number {i + 1}");
                    questions[i] = TFQuestions.AddTFQuestion();
                }
                else if (questionType == 2)
                {
                    Console.WriteLine($"the data of Choose one Question Number {i + 1}");
                    questions[i] = ChooseOneQuestion.AddChooseOneQuestion();
                }
                else if(questionType == 3)
                {
                    Console.WriteLine($"the data of MCQ Question Number {i + 1}");
                    questions[i] = MCQ_Question.AddMCQ_Question();
                }
            }

            return questions;
        }
    }
}
