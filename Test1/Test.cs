using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Cryptography;

namespace Test1
{
    [Serializable]
    public class Test
    {
        List<Question> questionList;
        string name;
        string password;
        public Test(string _name)
        {
            name = _name;
            questionList = new List<Question>();
        }
        public void Add(Question _question)
        {
            questionList.Add(_question);
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public int qQuestion
        {
            get
            {
                return questionList.Count;
            }
        }
        public Question getQuestion(int number)
        {
            if (number >= questionList.Count) throw (new IndexOutOfRangeException("Out of range"));
            return questionList[number];
        }
        public void Del(int position)
        {
            questionList.RemoveAt(position - 1);
        }
        public void ChangeAtPosition(Question q, int position)
        {
            position--;
            questionList.RemoveAt(position);
            questionList.Insert(position, q);
        }
        public void Clear()
        {
            questionList.Clear();
            name = "";
            password = "";
        }
        public string Password
        {
            set
            {
                password = string.Empty;
                foreach (byte b in new MD5CryptoServiceProvider().ComputeHash(Encoding.Default.GetBytes(value)))
                {
                    password += b.ToString("X2");
                }
            }
        }

        public bool ChekPassword(string _password)
        {

            string hash = string.Empty;

            foreach (byte b in new MD5CryptoServiceProvider().ComputeHash(Encoding.Default.GetBytes(_password)))
            {
                hash += b.ToString("X2");
            }
            return (hash == password) ? true : false;
        }
        public void MoveForward (int questionNumber)
        {
            var temp = questionList[questionNumber - 1];
            questionList[questionNumber - 1] = questionList[questionNumber];
            questionList[questionNumber] = temp;
        }
        public void MoveBack(int questionNumber)
        {
            
            var temp = questionList[questionNumber - 1];
            questionList[questionNumber - 1] = questionList[questionNumber-2];
            questionList[questionNumber-2] = temp;
        }
    }

}

