using System;
using System.Windows.Forms;

namespace CaoQuangNhat_2123110077_1_
{
    public partial class FormBai10 : Form
    {
        // --- 1. Khai báo biến "Bộ nhớ" ---
        decimal workingMemory = 0; // Biến để lưu số thứ nhất
        string opr = "";           // Biến để lưu phép tính (+ hoặc *)

        public FormBai10()
        {
            InitializeComponent();
        }

        // --- 2. Xử lý khi bấm các NÚT SỐ (0, 1, 2, 3...) ---
        // Mẹo: Bạn có thể copy hàm này cho các nút số khác
        private void bt0_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "0"; // Nối thêm số 0 vào màn hình
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "1"; // Nối thêm số 1
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "2";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "3";
        }

        private void btCham_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu chưa có dấu chấm nào thì mới cho thêm
            if (!tbDisplay.Text.Contains("."))
            {
                tbDisplay.Text += ".";
            }
        }

        // --- 3. Xử lý khi bấm PHÉP TÍNH (+, *) ---
        private void btCong_Click(object sender, EventArgs e)
        {
            opr = "+"; // Ghi nhớ là đang muốn Cộng
            workingMemory = decimal.Parse(tbDisplay.Text); // Lưu số đang hiện vào bộ nhớ
            tbDisplay.Clear(); // Xóa màn hình để nhập số thứ 2
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            opr = "*"; // Ghi nhớ là đang muốn Nhân
            workingMemory = decimal.Parse(tbDisplay.Text);
            tbDisplay.Clear();
        }

        // --- 4. Xử lý khi bấm DẤU BẰNG (=) ---
        private void btBang_Click(object sender, EventArgs e)
        {
            // Lấy số thứ 2 đang nhập trên màn hình
            decimal secondValue = decimal.Parse(tbDisplay.Text);

            // Tính toán dựa trên phép tính đã nhớ (opr)
            if (opr == "+")
            {
                tbDisplay.Text = (workingMemory + secondValue).ToString();
            }

            if (opr == "*")
            {
                tbDisplay.Text = (workingMemory * secondValue).ToString();
            }
        }
    }
}