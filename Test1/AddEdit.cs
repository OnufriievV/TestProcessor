using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    
    public partial class formQuestion : Form
    {
        int questionNumber;
        Test test;
        int mode;
        public formQuestion(Test _test, int _questionNumber, int _mode)
        {
            InitializeComponent();
            test = _test;
            questionNumber = _questionNumber;
            this.Text = ("Question: " + questionNumber);
            testName.Text = test.Name;
            mode = _mode;

            if (mode == 0)
            {
                Question q = test.getQuestion(questionNumber - 1);
                questionText.Text = q.QuestionText;
                string[] answers = q.Answers;
                for(int i = 0; i<answers.Length; i++)
                {
                    checkedListBox1.Items.Add(answers[i]);
                }
                checkedListBox1.SetItemChecked(q.RightAnswer, true);
            }

        }

        public int Mode
        {
            get { return mode; }
        }
        public int QuestionNumber
            {
            get
            {
                return questionNumber;
            }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(textBox2.Text);
            textBox2.Clear();
            textBox2.Focus();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            textBox2.Text = checkedListBox1.GetItemText(checkedListBox1.SelectedItem);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Insert(checkedListBox1.SelectedIndex, textBox2.Text);
            checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);

            textBox2.Clear();
        }

        private void del_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
        }

        private void up_Click(object sender, EventArgs e)
        {
            int selectedPosition = checkedListBox1.SelectedIndex;
            if (selectedPosition > 0)
            {
                CheckState isCheked = checkedListBox1.GetItemCheckState(checkedListBox1.SelectedIndex);
                checkedListBox1.Items.Insert(checkedListBox1.SelectedIndex - 1, checkedListBox1.SelectedItem);
                checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
                checkedListBox1.SelectedIndex = selectedPosition - 1;
                checkedListBox1.SetItemChecked(checkedListBox1.SelectedIndex, (isCheked == CheckState.Checked));
            }
        }

        private void down_Click(object sender, EventArgs e)
        {

            int selectedPosition = checkedListBox1.SelectedIndex;
            if ((selectedPosition < checkedListBox1.Items.Count - 1)&&(selectedPosition>-1))
            {
                CheckState isCheked = checkedListBox1.GetItemCheckState(checkedListBox1.SelectedIndex);
                checkedListBox1.Items.Insert(checkedListBox1.SelectedIndex + 2, checkedListBox1.SelectedItem);
                checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
                checkedListBox1.SelectedIndex = selectedPosition + 1;
                checkedListBox1.SetItemChecked(checkedListBox1.SelectedIndex, (isCheked == CheckState.Checked));
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                    if (e.Index != i) checkedListBox1.SetItemChecked(i, false);

        }

        private void Next_Click(object sender, EventArgs e)
        {
            
            this.Text = ("Question: " + questionNumber);
                if (testName.Text == "") MessageBox.Show("Please fill the test name!");
                else if (questionText.Text == "") MessageBox.Show("Please fill the question!");
                else if (checkedListBox1.Items.Count < 2) MessageBox.Show("Please fill at less 2 answers!");
                else if (checkedListBox1.CheckedIndices.Count < 1) MessageBox.Show("Please chek the right answer");

                else if (mode == 1)
                {

                    int numberRightQuestion = 0;
                    for (int i = 0; i < checkedListBox1.Items.Count; i++)
                        if (checkedListBox1.GetItemChecked(i))
                        {
                            numberRightQuestion = i;
                            break;
                        }
                    string[] question = new string[checkedListBox1.Items.Count];
                    for (int i = 0; i < checkedListBox1.Items.Count; i++)
                        question[i] = checkedListBox1.Items[i].ToString();
                    test.Add(new Question(questionText.Text, numberRightQuestion, question));
                    test.Name = testName.Text;

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    int numberRightQuestion = 0;
                    for (int i = 0; i < checkedListBox1.Items.Count; i++)
                        if (checkedListBox1.GetItemChecked(i))
                        {
                            numberRightQuestion = i;
                            break;
                        }
                    string[] question = new string[checkedListBox1.Items.Count];
                    for (int i = 0; i < checkedListBox1.Items.Count; i++)
                        question[i] = checkedListBox1.Items[i].ToString();
                    test.ChangeAtPosition(new Question(questionText.Text, numberRightQuestion, question), questionNumber);
                    test.Name = testName.Text;

                    this.DialogResult = DialogResult.OK;
                }

                

        }

        private void Prev_Click(object sender, EventArgs e)
        {
             if (questionNumber>1)
             {
                 questionNumber--;
                 questionText.Text = "";
                 checkedListBox1.Items.Clear();
                 this.Text = ("Question: " + questionNumber);
                 Question q = test.getQuestion(questionNumber - 1);
                 questionText.Text = q.QuestionText;
                 for (int i = 0; i < q.Answers.Length; i++)
                     checkedListBox1.Items.Add(q.Answers[i]);
                 checkedListBox1.SetItemChecked(q.RightAnswer, true);
             }
        }
    }
}
