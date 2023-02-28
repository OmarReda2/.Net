using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class PracticalExam : Exam, ICloneable
    {
        public override ExamType Type { get; } = ExamType.finalExam;
        public PracticalExam(int _time, int _numberOfQuestions) : base(_time, _numberOfQuestions)
        {
            Answers = new Answers[_numberOfQuestions];
        }

        public override void ShowExam()
        {
            base.ShowExam();
            showExamResult();
        }

        public void showExamResult()
        {
            Console.WriteLine("The right answers :");
            double grade = 0;

            for (int i = 0; i < Questions?.Length; i++)
            {
                if (Questions[i].GetType().Name == "MCQ_Question")
                {
                    string answer = "";
                    string[] Arr = Questions[i].RightAnswer.AnswerText.Split(",");

                    for (int j = 0; j < Arr?.Length; j++)
                    {
                        if (Arr[j] == Questions[i].AnswerList[j].AnswerText)
                        {
                            answer += Questions[i].AnswerList[0].AnswerText + " ";
                        }
                        else if (Arr[i] == Questions[i].AnswerList[i].AnswerText)
                        {
                            answer += Questions[i].AnswerList[1].AnswerText + " ";
                        }
                    }
                    Console.WriteLine($"Question {i + 1} {Questions[i].Body} : {answer}");
                }
                else
                {
                    Console.WriteLine($"Question {i + 1} {Questions[i].Body} : {Questions[i].RightAnswer.AnswerText}");

                }

                if (Answers[i].AnswerText == Questions[i].RightAnswer.AnswerText)
                {
                    grade = Questions[i].Marks;
                }

            }
            Console.WriteLine($"Your Grade  is {grade} from {ExamGrade}");
        }

        public object Clone()
        {
            return new PracticalExam(Time, NumberOfQuestions);
        }
    }
}
