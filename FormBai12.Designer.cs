namespace CaoQuangNhat_2123110077_1_
{
    partial class FormBai12
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
            btOK = new Button();
            tbDisplay = new TextBox();
            btCancel = new Button();
            SuspendLayout();
            // 
            // cb_Faculty
            // 
            cb_Faculty.FormattingEnabled = true;
            cb_Faculty.Items.AddRange(new object[] { "Công nghệ thông tin", "Kế toán", "Cơ khí", "Điện", "Hóa", "Cơ khí động lực" });
            cb_Faculty.Location = new Point(49, 48);
            cb_Faculty.Name = "cb_Faculty";
            cb_Faculty.Size = new Size(714, 33);
            cb_Faculty.TabIndex = 0;
            cb_Faculty.Text = "Chọn khoa";
            // 
            // btOK
            // 
            btOK.Location = new Point(533, 378);
            btOK.Name = "btOK";
            btOK.Size = new Size(112, 34);
            btOK.TabIndex = 1;
            btOK.Text = "OK";
            btOK.UseMnemonic = false;
            btOK.UseVisualStyleBackColor = true;
            btOK.Click += btOK_Click;
            // 
            // tbDisplay
            // 
            tbDisplay.Location = new Point(49, 111);
            tbDisplay.Multiline = true;
            tbDisplay.Name = "tbDisplay";
            tbDisplay.Size = new Size(714, 261);
            tbDisplay.TabIndex = 2;
            // 
            // btCancel
            // 
            btCancel.Location = new Point(651, 378);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(112, 34);
            btCancel.TabIndex = 3;
            btCancel.Text = "Cancel";
            btCancel.UseVisualStyleBackColor = true;
            btCancel.Click += btCancel_Click;
            // 
            // FormBai12
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btCancel);
            Controls.Add(tbDisplay);
            Controls.Add(btOK);
            Controls.Add(cb_Faculty);
            Name = "FormBai12";
            Text = "FormBai12";
            Load += FormBai12_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_Faculty;
        private Button btOK;
        private TextBox tbDisplay;
        private Button btCancel;
    }
}