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
    public partial class formPassword : Form
    {
        Test test;
        int mode;
        public formPassword(Test _test, int _mode=0)
        {
            InitializeComponent();
            mode = _mode;
            test = _test;
            if (mode ==1)
            {
                textConfirmPassword.Hide();
                comfirmPassword.Hide();
            }

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (mode != 1)
            {
                if (textPasword.Text == textConfirmPassword.Text)
                {
                    test.Password = textPasword.Text;
                    this.DialogResult = DialogResult.OK;
                }
                else MessageBox.Show("The passwords do not match", "Warning");
            }
            else
            {
                if (test.ChekPassword(textPasword.Text))
                    this.DialogResult = DialogResult.OK;
                else MessageBox.Show("The password is incorrect", "Error");
            }
        }
    }
}
