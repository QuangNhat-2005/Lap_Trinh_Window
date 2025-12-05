using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;                // Thư viện Đọc/Ghi file
using System.Xml.Serialization; // Thư viện xử lý XML

namespace CaoQuangNhat_2123110077_1_
{
    public partial class FormBai3 : Form
    {
        
        string path = Application.StartupPath + "\\form.xml";

        public FormBai3()
        {
            InitializeComponent();
        }

        // --- HÀM 1: GHI FILE (SAVE) ---
       
        public void Write(InfoWindows iw)
        {
            try
            {
                XmlSerializer writer = new XmlSerializer(typeof(InfoWindows));
                StreamWriter file = new StreamWriter(path);
                writer.Serialize(file, iw);
                file.Close();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi ghi: " + ex.Message); }
        }

        // --- HÀM 2: ĐỌC FILE (LOAD) - MỚI ---
        // Hàm này sẽ đọc file xml và trả về đối tượng InfoWindows
        public InfoWindows Read()
        {
            try
            {
                // Kiểm tra xem file có tồn tại không trước khi đọc
                if (!File.Exists(path)) return null;

                XmlSerializer reader = new XmlSerializer(typeof(InfoWindows));
                StreamReader file = new StreamReader(path);

                // Đọc nội dung và ép kiểu về InfoWindows
                InfoWindows iw = (InfoWindows)reader.Deserialize(file);
                file.Close();
                return iw;
            }
            catch (Exception)
            {
                return null; // Nếu lỗi thì trả về rỗng
            }
        }

        // --- SỰ KIỆN 1: MỞ FORM LÊN (LOAD) ---
        private void FormBai3_Load(object sender, EventArgs e)
        {
            // 1. Gọi hàm đọc file
            InfoWindows iw = Read();

            // 2. Nếu đọc được dữ liệu (tức là file có tồn tại)
            if (iw != null)
            {
                // 3. Gán kích thước cũ vào Form hiện tại
                this.Width = iw.Width;
                this.Height = iw.Height;

                this.Text = "Đã khôi phục size: " + iw.Width + " - " + iw.Height;
            }
            else
            {
                this.Text = "Chưa có dữ liệu cũ. Mời bạn kéo to nhỏ thử.";
            }
        }

        // --- SỰ KIỆN 2: KÉO XONG (RESIZE END) ---
        private void FormBai3_ResizeEnd(object sender, EventArgs e)
        {
            // Lấy kích thước hiện tại
            InfoWindows iw = new InfoWindows();
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;

            // Lưu lại ngay lập tức
            Write(iw);

            this.Text = "Đang lưu size mới: " + iw.Width + " - " + iw.Height;
        }
    }
}