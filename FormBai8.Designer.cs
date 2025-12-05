namespace CaoQuangNhat_2123110077_1_
{
    partial class FormBai8
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
            lbSoX = new Label();
            lbSoY = new Label();
            lbKetQua = new Label();
            tbSoX = new TextBox();
            tbSoY = new TextBox();
            tbKetQua = new TextBox();
            btCong = new Button();
            btNhan = new Button();
            btThoat = new Button();
            SuspendLayout();
            // 
            // lbSoX
            // 
            lbSoX.AutoSize = true;
            lbSoX.Location = new Point(89, 95);
            lbSoX.Name = "lbSoX";
            lbSoX.Size = new Size(46, 25);
            lbSoX.TabIndex = 0;
            lbSoX.Text = "Số x";
            // 
            // lbSoY
            // 
            lbSoY.AutoSize = true;
            lbSoY.Location = new Point(89, 155);
            lbSoY.Name = "lbSoY";
            lbSoY.Size = new Size(47, 25);
            lbSoY.TabIndex = 1;
            lbSoY.Text = "Số y";
            // 
            // lbKetQua
            // 
            lbKetQua.AutoSize = true;
            lbKetQua.Location = new Point(89, 210);
            lbKetQua.Name = "lbKetQua";
            lbKetQua.Size = new Size(72, 25);
            lbKetQua.TabIndex = 2;
            lbKetQua.Text = "Kết quả";
            // 
            // tbSoX
            // 
            tbSoX.Location = new Point(182, 89);
            tbSoX.Name = "tbSoX";
            tbSoX.Size = new Size(308, 31);
            tbSoX.TabIndex = 3;
            // 
            // tbSoY
            // 
            tbSoY.Location = new Point(182, 149);
            tbSoY.Name = "tbSoY";
            tbSoY.Size = new Size(308, 31);
            tbSoY.TabIndex = 4;
            // 
            // tbKetQua
            // 
            tbKetQua.Location = new Point(182, 204);
            tbKetQua.Name = "tbKetQua";
            tbKetQua.Size = new Size(308, 31);
            tbKetQua.TabIndex = 5;
            // 
            // btCong
            // 
            btCong.Location = new Point(89, 282);
            btCong.Name = "btCong";
            btCong.Size = new Size(112, 34);
            btCong.TabIndex = 6;
            btCong.Text = "Cộng";
            btCong.UseVisualStyleBackColor = true;
            btCong.Click += btCong_Click;
            // 
            // btNhan
            // 
            btNhan.Location = new Point(221, 282);
            btNhan.Name = "btNhan";
            btNhan.Size = new Size(112, 34);
            btNhan.TabIndex = 7;
            btNhan.Text = "Nhân";
            btNhan.UseVisualStyleBackColor = true;
            btNhan.Click += btNhan_Click;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(378, 282);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(112, 34);
            btThoat.TabIndex = 8;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // FormBai8
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 450);
            Controls.Add(btThoat);
            Controls.Add(btNhan);
            Controls.Add(btCong);
            Controls.Add(tbKetQua);
            Controls.Add(tbSoY);
            Controls.Add(tbSoX);
            Controls.Add(lbKetQua);
            Controls.Add(lbSoY);
            Controls.Add(lbSoX);
            Name = "FormBai8";
            Text = "FormBai8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbSoX;
        private Label lbSoY;
        private Label lbKetQua;
        private TextBox tbSoX;
        private TextBox tbSoY;
        private TextBox tbKetQua;
        private Button btCong;
        private Button btNhan;
        private Button btThoat;
    }
}