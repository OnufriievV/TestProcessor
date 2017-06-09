using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace Test1
{
    public partial class Form1 : Form
    {
        Test test;
        public Form1(Test _test)
        {
            InitializeComponent();
            this.Text =("Test processor " +"- No test loaded");
            test = _test;
        }
        

        //click button "Edit"
        private void Edit_library_Click(object sender, EventArgs e)
        {
                    
            if (test != null)
            {
                if (new formPassword(test, 1).ShowDialog() == DialogResult.OK)
                {
                    formRevue formquestion = new formRevue(test);
                    formquestion.Owner = this;
                    formquestion.ShowDialog();
                }
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if ((test != null) && (test.qQuestion!=0))
            {
                if (MessageBox.Show("All unsaved data will be deleted", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    test.Clear();
                    this.Text = ("Test processor " + "- No test loaded");
                    formRevue formquestion = new formRevue(test);
                    formquestion.Owner = this;
                    formquestion.ShowDialog();
                }
            }
            else
            {
                test = new Test("");
                formRevue formquestion = new formRevue(test);
                formquestion.Owner = this;
                formquestion.ShowDialog();
            }

        }
        // click button "Load"
        private void button1_Click(object sender, EventArgs e)
        {
            if (load.ShowDialog() == DialogResult.OK)
            {
                //Test test_1 = new Test("Noname");
                FileStream FS = new FileStream(load.FileName, FileMode.Open, FileAccess.Read);
                try
                {
                    BinaryFormatter BF = new BinaryFormatter();
                    FS.Seek(0, SeekOrigin.Begin);
                    test = (Test)BF.Deserialize(FS);
                    this.Text = ("Test processor - " + test.Name);

                }
                catch (SerializationException er)
                {
                    MessageBox.Show("Failed to deserialize. Reason: " + er.Message, "Error");
                }
                finally
                {                  
                    FS.Close();
                }
            }
             
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if ((test != null) && test.qQuestion != 0)
            {
                formRevue runTest = new formRevue(test, 1);
                runTest.ShowDialog();
            }
        }
    }
}
