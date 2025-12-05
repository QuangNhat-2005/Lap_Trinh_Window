namespace CaoQuangNhat_2123110077_1_
{
    partial class FormBai10
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
            tbDisplay = new TextBox();
            bt0 = new Button();
            bt1 = new Button();
            bt2 = new Button();
            bt3 = new Button();
            btCong = new Button();
            btCham = new Button();
            btNhan = new Button();
            btBang = new Button();
            SuspendLayout();
            // 
            // tbDisplay
            // 
            tbDisplay.Font = new Font("Segoe UI", 20F);
            tbDisplay.Location = new Point(41, 36);
            tbDisplay.Name = "tbDisplay";
            tbDisplay.Size = new Size(495, 61);
            tbDisplay.TabIndex = 0;
            tbDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // bt0
            // 
            bt0.Location = new Point(41, 118);
            bt0.Name = "bt0";
            bt0.Size = new Size(112, 103);
            bt0.TabIndex = 1;
            bt0.Text = "0";
            bt0.UseVisualStyleBackColor = true;
            bt0.Click += bt0_Click;
            // 
            // bt1
            // 
            bt1.Location = new Point(162, 118);
            bt1.Name = "bt1";
            bt1.Size = new Size(112, 103);
            bt1.TabIndex = 2;
            bt1.Text = "1";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += bt1_Click;
            // 
            // bt2
            // 
            bt2.Location = new Point(292, 118);
            bt2.Name = "bt2";
            bt2.Size = new Size(112, 103);
            bt2.TabIndex = 3;
            bt2.Text = "2";
            bt2.UseVisualStyleBackColor = true;
            bt2.Click += bt3_Click;
            // 
            // bt3
            // 
            bt3.Location = new Point(424, 118);
            bt3.Name = "bt3";
            bt3.Size = new Size(112, 103);
            bt3.TabIndex = 4;
            bt3.Text = "3";
            bt3.UseVisualStyleBackColor = true;
            // 
            // btCong
            // 
            btCong.Location = new Point(41, 227);
            btCong.Name = "btCong";
            btCong.Size = new Size(112, 98);
            btCong.TabIndex = 5;
            btCong.Text = "+";
            btCong.UseVisualStyleBackColor = true;
            btCong.Click += btCong_Click;
            // 
            // btCham
            // 
            btCham.Location = new Point(292, 227);
            btCham.Name = "btCham";
            btCham.Size = new Size(112, 98);
            btCham.TabIndex = 6;
            btCham.Text = ".";
            btCham.UseVisualStyleBackColor = true;
            btCham.Click += btCham_Click;
            // 
            // btNhan
            // 
            btNhan.Location = new Point(162, 227);
            btNhan.Name = "btNhan";
            btNhan.Size = new Size(112, 98);
            btNhan.TabIndex = 7;
            btNhan.Text = "*";
            btNhan.UseVisualStyleBackColor = true;
            btNhan.Click += btNhan_Click;
            // 
            // btBang
            // 
            btBang.Location = new Point(424, 227);
            btBang.Name = "btBang";
            btBang.Size = new Size(112, 98);
            btBang.TabIndex = 8;
            btBang.Text = "=";
            btBang.UseVisualStyleBackColor = true;
            btBang.Click += btBang_Click;
            // 
            // FormBai10
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 450);
            Controls.Add(btBang);
            Controls.Add(btNhan);
            Controls.Add(btCham);
            Controls.Add(btCong);
            Controls.Add(bt3);
            Controls.Add(bt2);
            Controls.Add(bt1);
            Controls.Add(bt0);
            Controls.Add(tbDisplay);
            Name = "FormBai10";
            Text = "FormBai10";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbDisplay;
        private Button bt0;
        private Button bt1;
        private Button bt2;
        private Button bt3;
        private Button btCong;
        private Button btCham;
        private Button btNhan;
        private Button btBang;
    }
}