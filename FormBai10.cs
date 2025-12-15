using System;
using System.Windows.Forms;

namespace CaoQuangNhat_2123110077_1_
{
    public partial class FormBai10 : Form
    {
        public FormBai10()
        {
            InitializeComponent();
        }

        // --- 1. Xử lý các NÚT SỐ (Giữ nguyên) ---
        private void bt0_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "0";
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "1";
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
            // Kiểm tra: Nếu chưa có dấu chấm nào trong số hiện tại mới cho thêm
            // (Lưu ý: Logic này đơn giản, nếu nhập 1.2+3.4 có thể cần check kỹ hơn, nhưng tạm thời để vầy cho dễ hiểu)
            if (!tbDisplay.Text.Contains("."))
            {
                tbDisplay.Text += ".";
            }
        }

        // --- 2. Xử lý PHÉP TÍNH (Sửa đổi: Chỉ nối thêm dấu, không xóa màn hình) ---
        private void btCong_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "+"; // Hiện dấu + lên màn hình
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "*"; // Hiện dấu * lên màn hình
        }

        // --- 3. Xử lý nút BẰNG (Thay đổi hoàn toàn: Cắt chuỗi để tính) ---
        private void btBang_Click(object sender, EventArgs e)
        {
            try
            {
                string bieuthuc = tbDisplay.Text; // Lấy toàn bộ chuỗi, ví dụ "10+5"

                // TRƯỜNG HỢP 1: Phép Cộng (+)
                if (bieuthuc.Contains("+"))
                {
                    // Cắt chuỗi tại dấu +
                    // Ví dụ "10+5" -> mảng gồm ["10", "5"]
                    string[] parts = bieuthuc.Split('+');

                    decimal so1 = decimal.Parse(parts[0]);
                    decimal so2 = decimal.Parse(parts[1]);

                    decimal ketQua = so1 + so2;

                    // Hiện kết quả
                    tbDisplay.Text = ketQua.ToString();
                }
                // TRƯỜNG HỢP 2: Phép Nhân (*)
                else if (bieuthuc.Contains("*"))
                {
                    string[] parts = bieuthuc.Split('*');

                    decimal so1 = decimal.Parse(parts[0]);
                    decimal so2 = decimal.Parse(parts[1]);

                    decimal ketQua = so1 * so2;

                    tbDisplay.Text = ketQua.ToString();
                }
            }
            catch (Exception)
            {
                // Báo lỗi nếu người dùng nhập sai (ví dụ: "1++2" hoặc bấm Bằng khi trống)
                MessageBox.Show("Lỗi biểu thức! Vui lòng nhập đúng dạng: Số + Số");
            }
        }
    }
}