namespace Student_Form
{
    partial class StudentInfo
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
            label1 = new Label();
            versionLabel = new Label();
            label2 = new Label();
            userDetail = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            labelEmail = new Label();
            saveFileDialog1 = new SaveFileDialog();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            pageSetupDialog1 = new PageSetupDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 26);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "Version:";
            // 
            // versionLabel
            // 
            versionLabel.AutoSize = true;
            versionLabel.Location = new Point(79, 26);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new Size(38, 15);
            versionLabel.TabIndex = 1;
            versionLabel.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(360, 49);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 2;
            label2.Text = "User";
            // 
            // userDetail
            // 
            userDetail.AutoSize = true;
            userDetail.Location = new Point(356, 82);
            userDetail.Name = "userDetail";
            userDetail.Size = new Size(38, 15);
            userDetail.TabIndex = 3;
            userDetail.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(352, 164);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 6;
            label4.Text = "Course Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(352, 209);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 7;
            label5.Text = "Course ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 68);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 8;
            label3.Text = "Email:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(79, 68);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(38, 15);
            labelEmail.TabIndex = 9;
            labelEmail.Text = "label6";
            // 
            // button1
            // 
            button1.Location = new Point(343, 405);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Export to:";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(440, 163);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(109, 23);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(440, 201);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(109, 23);
            textBox2.TabIndex = 12;
            // 
            // button2
            // 
            button2.Location = new Point(697, 41);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "Print";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // StudentInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(labelEmail);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(userDetail);
            Controls.Add(label2);
            Controls.Add(versionLabel);
            Controls.Add(label1);
            Name = "StudentInfo";
            Text = "StudentInfo";
            Load += StudentInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label versionLabel;
        private Label label2;
        private Label userDetail;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label labelEmail;
        private SaveFileDialog saveFileDialog1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private PageSetupDialog pageSetupDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}