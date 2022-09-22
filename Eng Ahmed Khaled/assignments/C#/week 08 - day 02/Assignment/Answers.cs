using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Answers : ICloneable
    {
        public string answerText;
        public int answerId;


        public string AnswerText
        {
            get { return answerText; }
            set { answerText = value; }
        }

        public int AnswerId
        {
            get { return answerId; }
            set {  answerId = value; }
        }


        public Answers(string _answerText, int _answetId)
        {
            answerText = _answerText;
            answerId = _answetId;
        }

        public Answers()
        {

        }

        public object Clone()
        {
            return new Answers(answerText, answerId);
        }
    }


}
