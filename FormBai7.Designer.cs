namespace CaoQuangNhat_2123110077_1_
{
    partial class FormBai7
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
            tbYear = new TextBox();
            label2 = new Label();
            tbPhone = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 103);
            label1.Name = "label1";
            label1.Size = new Size(44, 25);
            label1.TabIndex = 0;
            label1.Text = "Year";
            // 
            // tbYear
            // 
            tbYear.Location = new Point(207, 97);
            tbYear.Name = "tbYear";
            tbYear.Size = new Size(150, 31);
            tbYear.TabIndex = 1;
            tbYear.KeyPress += tbYear_KeyPress;
            tbYear.Validating += tbYear_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 154);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 2;
            label2.Text = "Phone Number";
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(207, 148);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(150, 31);
            tbPhone.TabIndex = 3;
            tbPhone.KeyPress += tbYear_KeyPress;
            // 
            // FormBai7
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbPhone);
            Controls.Add(label2);
            Controls.Add(tbYear);
            Controls.Add(label1);
            Name = "FormBai7";
            Text = "FormBai7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbYear;
        private Label label2;
        private TextBox tbPhone;
    }
}