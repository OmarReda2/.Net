using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment
{

    public enum ExamType
    {
        practicalExam = 1,
        finalExam = 2
    }
    public abstract class Exam
    {
        private int time;
        private int numberOfQuestions;
        private double examGrade;
        QuestionBase[] questions;
        Answers[] answers;


        public abstract ExamType Type { get; }

        public int Time
        {
            get { return time; }
            set { time = value; }
        }

        public int NumberOfQuestions
        {
            get { return numberOfQuestions; }
            set { numberOfQuestions = value; }
        }


        public double ExamGrade
        {
            get { return examGrade; }
            set { examGrade = value; }
        }

        public QuestionBase[] Questions
        {
            get { return questions; }
            set { questions = value; }
        }

        public Answers[] Answers
        {
            get { return answers; }
            set { answers = value; }
        }

        public Exam(int _time, int _numberOfQuestions)
        {
            time = _time;
            numberOfQuestions = _numberOfQuestions;
            ExamGrade = 0;
            questions = new QuestionBase[_numberOfQuestions];
            answers = new Answers[_numberOfQuestions];
        }

        public virtual void ShowExam()
        {
            for (int i = 0; i < questions?.Length; i++)
            {
                Console.WriteLine(questions[i]);
                Console.WriteLine("============================");

                int id;
                string answer = "";

                answers[i] = new Answers();

                if (questions[i].GetType().Name == "MCQ_Question")
                {
                    do
                    {
                        answer = Console.ReadLine();
                    } while (!(Regex.IsMatch(answer, "@[a-zA-Z]+$")));

                    answers[i].AnswerText = answer;
                }
                else
                {
                    do
                    {

                    } while (!int.TryParse(Console.ReadLine(), out id));

                    answers[i].AnswerId = id;

                    for (int j = 0; j < questions[i].AnswerList?.Length; j++)
                    {
                        if (questions[i].AnswerList[j].AnswerId == id)
                        {
                            answers[i].AnswerText = questions[i].AnswerList[j].AnswerText;
                        }
                    }

                }
                Console.WriteLine("===================================");

            }
        }
    }
}
