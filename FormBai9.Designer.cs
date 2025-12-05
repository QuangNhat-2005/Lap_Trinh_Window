namespace CaoQuangNhat_2123110077_1_
{
    partial class FormBai9
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
            label2 = new Label();
            label3 = new Label();
            tbSoX = new TextBox();
            tbSoY = new TextBox();
            tbKetQua = new TextBox();
            btLuu = new Button();
            btCong = new Button();
            btNhan = new Button();
            btThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 45);
            label1.Name = "label1";
            label1.Size = new Size(46, 25);
            label1.TabIndex = 0;
            label1.Text = "Số x";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 87);
            label2.Name = "label2";
            label2.Size = new Size(47, 25);
            label2.TabIndex = 1;
            label2.Text = "Số y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 134);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 2;
            label3.Text = "Kết quả";
            // 
            // tbSoX
            // 
            tbSoX.Location = new Point(169, 39);
            tbSoX.Name = "tbSoX";
            tbSoX.Size = new Size(586, 31);
            tbSoX.TabIndex = 3;
            // 
            // tbSoY
            // 
            tbSoY.Location = new Point(169, 87);
            tbSoY.Name = "tbSoY";
            tbSoY.Size = new Size(586, 31);
            tbSoY.TabIndex = 4;
            // 
            // tbKetQua
            // 
            tbKetQua.Location = new Point(169, 134);
            tbKetQua.Multiline = true;
            tbKetQua.Name = "tbKetQua";
            tbKetQua.ScrollBars = ScrollBars.Vertical;
            tbKetQua.Size = new Size(586, 369);
            tbKetQua.TabIndex = 5;
            // 
            // btLuu
            // 
            btLuu.Location = new Point(44, 533);
            btLuu.Name = "btLuu";
            btLuu.Size = new Size(112, 34);
            btLuu.TabIndex = 6;
            btLuu.Text = "Lưu";
            btLuu.UseVisualStyleBackColor = true;
            btLuu.Click += btLuu_Click;
            // 
            // btCong
            // 
            btCong.Location = new Point(381, 533);
            btCong.Name = "btCong";
            btCong.Size = new Size(112, 34);
            btCong.TabIndex = 7;
            btCong.Text = "Cộng";
            btCong.UseVisualStyleBackColor = true;
            btCong.Click += btCong_Click;
            // 
            // btNhan
            // 
            btNhan.Location = new Point(510, 533);
            btNhan.Name = "btNhan";
            btNhan.Size = new Size(112, 34);
            btNhan.TabIndex = 8;
            btNhan.Text = "Nhân";
            btNhan.UseVisualStyleBackColor = true;
            btNhan.Click += btNhan_Click;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(643, 533);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(112, 34);
            btThoat.TabIndex = 9;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // FormBai9
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 640);
            Controls.Add(btThoat);
            Controls.Add(btNhan);
            Controls.Add(btCong);
            Controls.Add(btLuu);
            Controls.Add(tbKetQua);
            Controls.Add(tbSoY);
            Controls.Add(tbSoX);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormBai9";
            Text = "FormBai9";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbSoX;
        private TextBox tbSoY;
        private TextBox tbKetQua;
        private Button btLuu;
        private Button btCong;
        private Button btNhan;
        private Button btThoat;
    }
}