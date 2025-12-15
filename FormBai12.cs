using System;
using System.Windows.Forms;

namespace CaoQuangNhat_2123110077_1_
{
    public partial class FormBai12 : Form
    {
        public FormBai12()
        {
            InitializeComponent();
        }

        // 1. Sự kiện khi Form vừa mở lên
        private void FormBai12_Load(object sender, EventArgs e)
        {
            // Chọn sẵn dòng thứ 3 (Cơ khí) để người dùng đỡ phải chọn
            // (Nếu không có dòng này, lúc đầu ComboBox sẽ trống trơn)
            cb_Faculty.SelectedIndex = 2;
        }

        // 2. Sự kiện khi người dùng chọn một dòng khác trong ComboBox
        private void cb_Faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy số thứ tự (Index)
            int index = cb_Faculty.SelectedIndex;

            // Hiện thử index ra màn hình (để biết code có chạy)
            tbDisplay.Text = "Bạn đang chọn mục thứ: " + index.ToString();
        }

        // 3. Xử lý nút OK
        private void btOK_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có đang chọn cái nào không (tránh lỗi nếu ComboBox trống)
            if (cb_Faculty.SelectedItem != null)
            {
                string item = cb_Faculty.SelectedItem.ToString();
                tbDisplay.Text = "Bạn là sinh viên khoa: " + item;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khoa!");
            }
        }

        // 4. Xử lý nút CANCEL (Thêm theo yêu cầu)
        private void btCancel_Click(object sender, EventArgs e)
        {
            // Cách 1: Xóa trắng để chọn lại
            // tbDisplay.Text = "";
            // cb_Faculty.SelectedIndex = -1; // -1 nghĩa là không chọn gì cả

            // Cách 2: Đóng Form (Thường nút Cancel hay dùng để thoát)
            // Tôi dùng cách này nhé:
            DialogResult hoi = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}