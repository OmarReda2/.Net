using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class ChooseOneQuestion : QuestionBase, ICloneable
    {
        public override string Header { get; } = "Choose one question";


        public ChooseOneQuestion(string _body = "", double _marks = 0) : base(_body, _marks)
        {
            AnswerList = new Answers[3];
        }

        public override string ToString()
        {
            return $"{Header}        Marks({Marks})\n{Body}\n" +
                $"1. {AnswerList[0].AnswerText}\t\t 2. {AnswerList[1].AnswerText}\t\t " +
                $"3. {AnswerList[2].AnswerText}";
        }


        public static ChooseOneQuestion AddChooseOneQuestion()
        {
            ChooseOneQuestion question = new ChooseOneQuestion();
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
            int id;
            do
            {
                Console.WriteLine($"Please enter the right answer for the questions [1, 2 or 3");
            } while (!int.TryParse(Console.ReadLine(), out id) || id < 1 || id > 3);

            question.RightAnswer.AnswerId = id;
            question.RightAnswer.AnswerText = question.AnswerList[id - 1].AnswerText;

            return question;
        }

        public object Clone()
        {
            return new ChooseOneQuestion(body, marks);
        }
    }
}
