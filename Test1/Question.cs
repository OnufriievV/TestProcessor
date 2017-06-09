using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
 [Serializable]
    public class Question
    {
        string questionText;
        int rightAnswer;
        string[] answers;
        public Question(string _questionText, int _rightAnswer, string [] _answers)
        {
            questionText = _questionText;
            
            rightAnswer = _rightAnswer;
            answers = _answers;
        }
        public string QuestionText
        {
            get
            {
                return questionText;
            }
        }

        public int RightAnswer
        {
            get
            {
                return rightAnswer;
            }
        }

        public string[] Answers
        {
            get
            {
                return answers;
            }
            set
            {
                //answers = new string[value.Length];
                answers = value;
            }

        }
    }
}
