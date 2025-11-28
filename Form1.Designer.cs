namespace CaoQuangNhat_2123110077_1_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlDanhSachBai = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // pnlDanhSachBai
            // 
            pnlDanhSachBai.AutoScroll = true;
            pnlDanhSachBai.Dock = DockStyle.Fill;
            pnlDanhSachBai.Location = new Point(0, 0);
            pnlDanhSachBai.Name = "pnlDanhSachBai";
            pnlDanhSachBai.Size = new Size(1206, 681);
            pnlDanhSachBai.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 681);
            Controls.Add(pnlDanhSachBai);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel pnlDanhSachBai;
    }
}
