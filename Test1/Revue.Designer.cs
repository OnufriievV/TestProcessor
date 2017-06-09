namespace Test1
{
    partial class formRevue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Prev = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.testName = new System.Windows.Forms.Label();
            this.questionText = new System.Windows.Forms.Label();
            this.addQuestion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Edit = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.saveTest = new System.Windows.Forms.SaveFileDialog();
            this.moveF = new System.Windows.Forms.Button();
            this.moveB = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.run = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question";
            // 
            // Prev
            // 
            this.Prev.Location = new System.Drawing.Point(21, 350);
            this.Prev.Name = "Prev";
            this.Prev.Size = new System.Drawing.Size(66, 33);
            this.Prev.TabIndex = 2;
            this.Prev.Text = "Prev";
            this.Prev.UseVisualStyleBackColor = true;
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(93, 350);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(69, 33);
            this.Next.TabIndex = 3;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(467, 350);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(123, 33);
            this.del.TabIndex = 4;
            this.del.Text = "Del";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Answers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Test name";
            // 
            // testName
            // 
            this.testName.AutoSize = true;
            this.testName.Location = new System.Drawing.Point(105, 19);
            this.testName.Name = "testName";
            this.testName.Size = new System.Drawing.Size(35, 13);
            this.testName.TabIndex = 17;
            this.testName.Text = "label4";
            // 
            // questionText
            // 
            this.questionText.AutoSize = true;
            this.questionText.Location = new System.Drawing.Point(105, 68);
            this.questionText.Name = "questionText";
            this.questionText.Size = new System.Drawing.Size(35, 13);
            this.questionText.TabIndex = 18;
            this.questionText.Text = "label4";
            // 
            // addQuestion
            // 
            this.addQuestion.Location = new System.Drawing.Point(209, 350);
            this.addQuestion.Name = "addQuestion";
            this.addQuestion.Size = new System.Drawing.Size(123, 33);
            this.addQuestion.TabIndex = 19;
            this.addQuestion.Text = "Add";
            this.addQuestion.UseVisualStyleBackColor = true;
            this.addQuestion.Click += new System.EventHandler(this.addQuestion_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(108, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 179);
            this.panel1.TabIndex = 20;
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(338, 350);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(123, 33);
            this.Edit.TabIndex = 21;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(209, 392);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(123, 33);
            this.save.TabIndex = 22;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // saveTest
            // 
            this.saveTest.Filter = "File test|*.dat";
            // 
            // moveF
            // 
            this.moveF.Location = new System.Drawing.Point(93, 392);
            this.moveF.Name = "moveF";
            this.moveF.Size = new System.Drawing.Size(66, 33);
            this.moveF.TabIndex = 23;
            this.moveF.Text = "Move>>";
            this.moveF.UseVisualStyleBackColor = true;
            this.moveF.Click += new System.EventHandler(this.moveF_Click);
            // 
            // moveB
            // 
            this.moveB.Location = new System.Drawing.Point(23, 392);
            this.moveB.Name = "moveB";
            this.moveB.Size = new System.Drawing.Size(64, 33);
            this.moveB.TabIndex = 24;
            this.moveB.Text = "<<Move";
            this.moveB.UseVisualStyleBackColor = true;
            this.moveB.Click += new System.EventHandler(this.moveB_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(338, 392);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(123, 33);
            this.clear.TabIndex = 25;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(467, 392);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(123, 33);
            this.run.TabIndex = 26;
            this.run.Text = "Run";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // formRevue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 437);
            this.Controls.Add(this.run);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.moveB);
            this.Controls.Add(this.moveF);
            this.Controls.Add(this.save);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addQuestion);
            this.Controls.Add(this.questionText);
            this.Controls.Add(this.testName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.del);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Prev);
            this.Controls.Add(this.label1);
            this.Name = "formRevue";
            this.Text = "Question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Prev;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label testName;
        private System.Windows.Forms.Label questionText;
        private System.Windows.Forms.Button addQuestion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.SaveFileDialog saveTest;
        private System.Windows.Forms.Button moveF;
        private System.Windows.Forms.Button moveB;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Timer timer1;
    }
}