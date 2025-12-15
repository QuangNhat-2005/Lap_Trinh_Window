namespace CaoQuangNhat_2123110077_1_
{
    partial class FormBai13
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
            cb_Faculty = new ComboBox();
            tbDisplay = new TextBox();
            btClear = new Button();
            btOK = new Button();
            SuspendLayout();
            // 
            // cb_Faculty
            // 
            cb_Faculty.FormattingEnabled = true;
            cb_Faculty.Location = new Point(172, 54);
            cb_Faculty.Name = "cb_Faculty";
            cb_Faculty.Size = new Size(402, 33);
            cb_Faculty.TabIndex = 0;
            // 
            // tbDisplay
            // 
            tbDisplay.Location = new Point(172, 114);
            tbDisplay.Multiline = true;
            tbDisplay.Name = "tbDisplay";
            tbDisplay.Size = new Size(402, 209);
            tbDisplay.TabIndex = 1;
            // 
            // btClear
            // 
            btClear.Location = new Point(326, 341);
            btClear.Name = "btClear";
            btClear.Size = new Size(112, 34);
            btClear.TabIndex = 2;
            btClear.Text = "Clear";
            btClear.UseVisualStyleBackColor = true;
            btClear.Click += btClear_Click;
            // 
            // btOK
            // 
            btOK.Location = new Point(462, 341);
            btOK.Name = "btOK";
            btOK.Size = new Size(112, 34);
            btOK.TabIndex = 3;
            btOK.Text = "OK";
            btOK.UseVisualStyleBackColor = true;
            btOK.Click += btOK_Click;
            // 
            // FormBai13
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 450);
            Controls.Add(btOK);
            Controls.Add(btClear);
            Controls.Add(tbDisplay);
            Controls.Add(cb_Faculty);
            Name = "FormBai13";
            Text = "FormBai13";
            Load += FormBai13_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_Faculty;
        private TextBox tbDisplay;
        private Button btClear;
        private Button btOK;
    }
}