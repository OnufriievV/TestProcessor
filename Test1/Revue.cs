using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Test1
{
    public partial class formRevue : Form
    {
        int questionNumber =0;
        Test test;
        int mode;
        int ticks = 0;
        int[] userAnswers = null;
        int qRightAnswers = 0;
        Button[] answersButtons = null;

        public formRevue(Test _test, int _mode=0)
        {
            InitializeComponent();
            test = _test;
            mode = _mode;
           
            
            if ((test == null) || (test.qQuestion == 0))
            {
                ShowQuestionOnTheForm(questionNumber);
            }
            else
            {
                questionNumber++;
                ShowQuestionOnTheForm(questionNumber);
            }
            if (mode ==1)
            {
                moveB.Hide();
                moveF.Hide();
                save.Hide();
                clear.Hide();
                run.Text=("Finish");
                addQuestion.Hide();
                clear.Hide();
                Edit.Hide();
                del.Hide();
                timer1.Start();
                userAnswers = new int[test.qQuestion];

            }

        }

        private void up_Click(object sender, EventArgs e) { }
        private void down_Click(object sender, EventArgs e) { }
        
        private void Next_Click(object sender, EventArgs e)
        {
            if (questionNumber < test.qQuestion)
            {
                if (mode==1)
                {
                    //panel1.
                }
                questionNumber++;
                ShowQuestionOnTheForm(questionNumber);
            }

        }

        private void Prev_Click(object sender, EventArgs e)
        {
            if (questionNumber > 1)
            {
                questionNumber--;
                ShowQuestionOnTheForm(questionNumber);
            }
        }
        

        private void addQuestion_Click(object sender, EventArgs e)
        {
            formQuestion fq = new formQuestion(test, test.qQuestion+1, 1);
            fq.Owner = this;
            fq.FormClosed += fq_FormClosed;
            fq.ShowDialog();
        }

        void fq_FormClosed(object sender, FormClosedEventArgs e)
        {
          
            formQuestion fq = (formQuestion)sender;
            if (fq.DialogResult == DialogResult.OK)
            {
                if (fq.Mode == 1) 
                    questionNumber++;
                ShowQuestionOnTheForm(questionNumber);

            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (questionNumber > 0)
            {
                test.Del(questionNumber);
                if (questionNumber > test.qQuestion)
                    questionNumber--;
            }
            ShowQuestionOnTheForm(questionNumber);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (test.qQuestion > 0)
            {
                formQuestion fq = new formQuestion(test, questionNumber, 0);
                fq.Owner = this;
                fq.FormClosed += fq_FormClosed;
                fq.ShowDialog();
            }
            else MessageBox.Show("No question to edit", "Info");
        }

        private void save_Click(object sender, EventArgs e)
        {
            formPassword fp = new formPassword(test);
            if (fp.ShowDialog() == DialogResult.OK)
                if (saveTest.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveTest.FileName;
                    FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, test);
                    fs.Close();
                }
        }

        

        //button Clear
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete all questions", "Warning") == DialogResult.OK)
            {
                test.Clear();
                questionNumber = 0;
                ShowQuestionOnTheForm(questionNumber);
            }
        }

        private void moveB_Click(object sender, EventArgs e)
        {
            if(questionNumber>1)
            {
                test.MoveBack(questionNumber);
                questionNumber--;
                ShowQuestionOnTheForm(questionNumber);

            }
        }

        private void moveF_Click(object sender, EventArgs e)
        {
            if (questionNumber < test.qQuestion)
            {
                test.MoveForward(questionNumber);
                questionNumber++;
                ShowQuestionOnTheForm(questionNumber);

            }
        }
        private void ShowQuestionOnTheForm(int questionNumber)
        {
            if (questionNumber==0)
            {
                this.Text = ("Question is absent");
                testName.Text = "Noname";
                questionText.Text = "Notext";
                panel1.Controls.Clear();
            }
            else
            {
                panel1.Controls.Clear();
                if (mode == 1)
                    this.Text = ("Question: " + questionNumber + " - " + ticksToStringTime(ticks));
                else if (mode == 2)
                    this.Text = ("Question: " + questionNumber + " - " + "Right answers: " + qRightAnswers + "/" + test.qQuestion + " - Pass time: " + ticksToStringTime(ticks));

                else this.Text = ("Question: " + questionNumber);
                Question question1 = test.getQuestion(questionNumber - 1);
                testName.Text = test.Name;
                questionText.Text = question1.QuestionText;
                string[] answers = question1.Answers;
                answersButtons = new Button[answers.Length];
                for (int i = 0; i < answersButtons.Length; i++)
                {
                    answersButtons[i] = new Button();
                    answersButtons[i].Click += formRevue_Click;
                    answersButtons[i].Width = 450;
                    answersButtons[i].Height = 30;
                    answersButtons[i].Location = new Point(0, (answersButtons[i].Height * i));
                    answersButtons[i].Tag = i + 1;
                    if ((mode == 2) && (i + 1 == userAnswers[questionNumber-1])) answersButtons[i].BackColor = Color.Red;
                    if (i == question1.RightAnswer)
                    {
                        switch (mode)
                        {
                            case 0: { answersButtons[i].Text = (answers[i] + " ✔"); break; }
                            case 1: { answersButtons[i].Text = (answers[i]); break; }
                            case 2: { answersButtons[i].Text = (answers[i]); answersButtons[i].BackColor = Color.Green; break; }

                        }
                        
                    }

                    else answersButtons[i].Text = (answers[i]);


                    if ((userAnswers != null) && (mode == 1) && (userAnswers[questionNumber - 1] == i + 1))
                        answersButtons[i].BackColor = Color.Green;
                    

                    panel1.Controls.Add(answersButtons[i]);
                    
                   if(Owner!=null) (Owner as Form1).Text = ("Test processor - " + test.Name); 
                      
                }
            }
        }

        void formRevue_Click(object sender, EventArgs e)
        {
            if (mode == 1)
            {
                Button b = sender as Button;
                if (b.BackColor == Color.Green)
                {
                    userAnswers[questionNumber - 1] = 0;
                    b.BackColor = Control.DefaultBackColor;
                }
                else
                {
                    foreach (Button but in panel1.Controls)
                    {
                        but.BackColor = Control.DefaultBackColor;
                    }
                    b.BackColor = Color.Green;
                    userAnswers[questionNumber - 1] = (int)b.Tag;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            this.Text = ("Question: " + questionNumber + " - " + ticksToStringTime(ticks));
        }

        private string ticksToStringTime(int _ticks)
        {
            int tempTicks = _ticks;
            string time = "";

            if ((tempTicks / 3600) < 1) { time += "00:"; }
            else if ((tempTicks / 3600) < 10) { time = time + "0" + (tempTicks / 3600).ToString() + ":"; }
            else time += (tempTicks / 3600).ToString();

            tempTicks = tempTicks - (tempTicks / 3600) * 3600;

            if ((tempTicks / 60) < 1) { time += "00:"; }
            else if ((tempTicks / 60) < 10) { time = time + "0" + (tempTicks / 60).ToString() + ":"; }
            else time = time + (tempTicks / 60).ToString() + ":";
            tempTicks = tempTicks - (tempTicks / 60) * 60;

            if (tempTicks < 10) { time = time + "0" + tempTicks.ToString(); }
            else { time = time + tempTicks.ToString(); }
            return time;
        }

        private void run_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if (mode == 1)
            {
                for (int i = 0; i < userAnswers.Length; i++)
                {
                    if (userAnswers[i] == 0)
                    {
                        MessageBox.Show("You have to answer\nQuestion: " + (i + 1), "Warning");
                        flag = true;
                        break;
                       
                    }
                }

                if (!flag)
                {
                    timer1.Stop();
                    mode = 2;
                    for (int k = 0; k < userAnswers.Length; k++)
                    {
                        if (userAnswers[k] == (test.getQuestion(k).RightAnswer + 1))
                        {
                            qRightAnswers++;
                        }


                    }

                    ShowQuestionOnTheForm(questionNumber);
                }



            }
            
        }
    }
    
}
