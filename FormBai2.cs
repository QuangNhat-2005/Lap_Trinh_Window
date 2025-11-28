using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace CaoQuangNhat_2123110077_1_
{
    public partial class FormBai2 : Form
    {
        // Đường dẫn file để lưu. 
        // Dùng "Application.StartupPath" để lưu ngay tại thư mục chạy phần mềm cho an toàn, đỡ bị lỗi quyền truy cập ổ C/D.
        string path = Application.StartupPath + "\\form.xml";

        public FormBai2()
        {
            InitializeComponent();
        }

        // Hàm dùng chung: Nhận vào thông tin kích thước -> Lưu xuống file
        public void Write(InfoWindows iw)
        {
            try
            {
                // Khởi tạo công cụ chuyển đổi sang XML
                XmlSerializer writer = new XmlSerializer(typeof(InfoWindows));

                // Tạo file để ghi
                StreamWriter file = new StreamWriter(path);

                // Thực hiện ghi dữ liệu
                writer.Serialize(file, iw);

                // Đóng file lại (quan trọng)
                file.Close();

                // Cập nhật tiêu đề để biết là đã lưu
                this.Text = "Đã lưu size: " + iw.Width + " - " + iw.Height;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu file: " + ex.Message);
            }
        }

        // Sự kiện Form Load
        private void FormBai2_Load(object sender, EventArgs e)
        {
            // Tạo đối tượng chứa dữ liệu
            InfoWindows iw = new InfoWindows();
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;

            // Gọi hàm lưu
            Write(iw);
        }

        // Sự kiện Kéo xong kích thước
        private void FormBai2_ResizeEnd(object sender, EventArgs e)
        {
            InfoWindows iw = new InfoWindows();
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;

            Write(iw);
        }
    }
}