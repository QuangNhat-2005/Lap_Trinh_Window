using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace CaoQuangNhat_2123110077_1_
{
    public partial class FormBai4 : Form
    {
        string path = Application.StartupPath + "\\form_bai4.xml"; // Đổi tên file khác để không đè lên bài cũ

        public FormBai4()
        {
            InitializeComponent();
        }

        // 1. Hàm Ghi (Copy từ bài cũ)
        public void Write(InfoWindows iw)
        {
            try
            {
                XmlSerializer writer = new XmlSerializer(typeof(InfoWindows));
                StreamWriter file = new StreamWriter(path);
                writer.Serialize(file, iw);
                file.Close();
            }
            catch { }
        }

        // 2. Hàm Đọc (Copy từ bài cũ)
        public InfoWindows Read()
        {
            try
            {
                if (!File.Exists(path)) return null;
                XmlSerializer reader = new XmlSerializer(typeof(InfoWindows));
                StreamReader file = new StreamReader(path);
                InfoWindows iw = (InfoWindows)reader.Deserialize(file);
                file.Close();
                return iw;
            }
            catch { return null; }
        }

        // --- SỰ KIỆN 1: LOAD FORM (KHÔI PHỤC) ---
        private void FormBai4_Load(object sender, EventArgs e)
        {
            InfoWindows iw = Read();
            if (iw != null)
            {
                // Khôi phục kích thước
                this.Width = iw.Width;
                this.Height = iw.Height;

                // MỚI: Khôi phục vị trí
                this.Location = iw.Location;
            }
        }

        // --- SỰ KIỆN 2: FORM CLOSING (LƯU KHI TẮT) ---
        // Lưu ý: Không dùng ResizeEnd nữa, dùng FormClosing
        private void FormBai4_FormClosing(object sender, FormClosingEventArgs e)
        {
            InfoWindows iw = new InfoWindows();

            // Lấy kích thước hiện tại
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;

            // MỚI: Lấy vị trí hiện tại
            iw.Location = this.Location;

            // Ghi xuống file
            Write(iw);

            // MessageBox.Show("Đã lưu trạng thái!"); // Bỏ comment dòng này nếu muốn test
        }
    }
}