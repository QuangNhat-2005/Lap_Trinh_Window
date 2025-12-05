using System;
using System.Windows.Forms;
using System.IO; 

namespace CaoQuangNhat_2123110077_1_
{
    public partial class FormBai5 : Form
    {
        public FormBai5()
        {
            InitializeComponent();
        }

        // Sự kiện: Khi người dùng nhả phím ra (KeyUp)
        private void FormBai5_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                // 1. Xác định đường dẫn file lưu (Lưu ngay cạnh file .exe)
                string path = Application.StartupPath + "\\Key_Logger.txt";

                // 2. Mở file để ghi (Tham số 'true' nghĩa là ghi nối tiếp, không xóa cái cũ)
                StreamWriter sw = new StreamWriter(path, true);

                // 3. Ghi phím vừa bấm vào file
                // e.KeyCode: Lấy mã phím (Ví dụ nhấn A thì lưu chữ A)
                sw.Write(e.KeyCode.ToString() + " ");

                // 4. Đóng file ngay lập tức để lưu dữ liệu
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi file: " + ex.Message);
            }
        }

        //Thêm sự kiện Load để thông báo cách thoát 
        private void FormBai5_Load(object sender, EventArgs e)
        {
            this.Text = "Đang ghi lại bàn phím... (Bấm Alt+F4 để thoát)";
        }
    }
}