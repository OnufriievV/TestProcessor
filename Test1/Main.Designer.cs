namespace Test1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Start = new System.Windows.Forms.Button();
            this.Edit_library = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.OpenFileDialog();
            this.Create = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(65, 25);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(144, 47);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start test";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Edit_library
            // 
            this.Edit_library.Location = new System.Drawing.Point(616, 25);
            this.Edit_library.Name = "Edit_library";
            this.Edit_library.Size = new System.Drawing.Size(144, 47);
            this.Edit_library.TabIndex = 1;
            this.Edit_library.Text = "Edit test";
            this.Edit_library.UseVisualStyleBackColor = true;
            this.Edit_library.Click += new System.EventHandler(this.Edit_library_Click);
            // 
            // load
            // 
            this.load.Filter = "File test|*.dat";
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(242, 26);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(144, 46);
            this.Create.TabIndex = 2;
            this.Create.Text = "Create test";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(426, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Load test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // save
            // 
            this.save.Filter = "File test|*.dat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 127);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Edit_library);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Edit_library;
        private System.Windows.Forms.OpenFileDialog load;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog save;
    }
}

