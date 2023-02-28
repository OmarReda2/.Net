using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment
{
    public class MCQ_Question : QuestionBase, ICloneable
    {
        public override string Header { get; } = "Choose Multi question";


        public MCQ_Question(string _body = "", double _marks = 0) : base(_body, _marks)
        {
            AnswerList = new Answers[3];
        }

        public override string ToString()
        {
            return $"{Header}        Marks({Marks})\n{Body}\n" +
                $"A. {AnswerList[0].AnswerText}\t\t B. {AnswerList[1].AnswerText}\t\t " +
                $"C. {AnswerList[2].AnswerText}";
        }


        public static MCQ_Question AddMCQ_Question()
        {
            MCQ_Question question = new MCQ_Question();
            Console.WriteLine(question.Header);

            Console.WriteLine("Please Enter the Body of the Question");
            question.Body = Console.ReadLine();

            Console.WriteLine("Please Enter the Marks of the Question");
            question.Marks = double.Parse(Console.ReadLine());

            Console.WriteLine("The choices of the question");
            for (int i = 0; i < question.AnswerList.Length; i++)
            {
                question.AnswerList[i] = new Answers();
                Console.WriteLine($"Please enter the choice number {i + 1}");
                question.AnswerList[i].AnswerText = Console.ReadLine();
                question.AnswerList[i].AnswerId = i + 1;
            }

            question.RightAnswer = new Answers();
            string answer = "";
            do
            {
                Console.WriteLine($"Please enter the right answer for the questions [1, 2 or 3");
            } while (!(answer is string));
            Regex.IsMatch(answer, @"^[a-zA-z]+$");

            question.RightAnswer.AnswerText = answer;


            return question;
        }

        public object Clone()
        {
            return new MCQ_Question(body, marks);
        }
    }
}
