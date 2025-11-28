using System;
using System.Drawing; 
using System.Windows.Forms;

namespace CaoQuangNhat_2123110077_1_ 
{
    public partial class FormBai1 : Form
    {
        public FormBai1()
        {
            InitializeComponent();
        }

        // Sự kiện chạy khi Form vừa mở lên
        private void FormBai1_Load(object sender, EventArgs e)
        {
            int width = this.Size.Width;   // Lấy chiều rộng
            int height = this.Size.Height; // Lấy chiều cao

            // Gán vào tiêu đề (Text)
            this.Text = width.ToString() + " - " + height.ToString();
        }

        // Sự kiện chạy khi người dùng KÉO XONG kích thước cửa sổ
        private void FormBai1_ResizeEnd(object sender, EventArgs e)
        {
            int width = this.Size.Width;
            int height = this.Size.Height;

            this.Text = width.ToString() + " - " + height.ToString();
        }
    }
}