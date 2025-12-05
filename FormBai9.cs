using System;
using System.Windows.Forms;
using System.IO;

namespace CaoQuangNhat_2123110077_1_
{
    public partial class FormBai9 : Form
    {
        public FormBai9()
        {
            InitializeComponent();
        }

        // 1. Nút CỘNG (Sửa lại để hiện lịch sử)
        private void btCong_Click(object sender, EventArgs e)
        {
            if (tbSoX.Text != "" && tbSoY.Text != "")
            {
                int x = int.Parse(tbSoX.Text);
                int y = int.Parse(tbSoY.Text);
                int kq = x + y;

                // Cũ: tbKetQua.Text = kq.ToString();
                // Mới: Cộng dồn chuỗi (+=) và thêm xuống dòng (\r\n)
                tbKetQua.Text += x + " + " + y + " = " + kq + "\r\n";
            }
        }

        // 2. Nút NHÂN
        private void btNhan_Click(object sender, EventArgs e)
        {
            if (tbSoX.Text != "" && tbSoY.Text != "")
            {
                int x = int.Parse(tbSoX.Text);
                int y = int.Parse(tbSoY.Text);
                int kq = x * y;

                // Cộng dồn lịch sử
                tbKetQua.Text += x + " * " + y + " = " + kq + "\r\n";
            }
        }

        // 3. Nút LƯU (Mới)
        private void btLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // Mở file (true nghĩa là ghi nối tiếp, không xóa cái cũ trong file)
                StreamWriter sw = new StreamWriter("Caculator.txt", true);

                // Ghi toàn bộ nội dung trong ô Kết quả vào file
                sw.Write(tbKetQua.Text);

                sw.Close();
                MessageBox.Show("Đã lưu lịch sử tính toán!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // 4. Nút THOÁT
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}