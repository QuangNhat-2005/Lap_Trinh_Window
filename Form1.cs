using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaoQuangNhat_2123110077_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Sự kiện chạy khi Form vừa hiện lên
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "KHO BÀI TẬP - CAO QUANG NHẬT";
            TaoDanhSachBaiTap();
        }

        void TaoDanhSachBaiTap()
        {
            // 1. Dọn dẹp bảng cũ
            pnlDanhSachBai.Controls.Clear();

            // Chỉnh màu nền cho cái bảng phía sau cho đẹp (Màu trắng khói)
            pnlDanhSachBai.BackColor = Color.WhiteSmoke;
            pnlDanhSachBai.Padding = new Padding(10); // Cách lề một chút cho thoáng

            // 2. Vòng lặp tạo nút
            for (int i = 1; i <= 30; i++)
            {
                Button btn = new Button();
                btn.Text = "Bài " + i;

                // --- PHẦN GIAO DIỆN ĐẸP ---

                // Kích thước nút to rõ ràng hơn
                btn.Width = 120;
                btn.Height = 60;
                btn.Margin = new Padding(10); // Cách nhau rộng rãi

                // Font chữ hiện đại (Segoe UI, đậm, cỡ 12)
                btn.Font = new Font("Segoe UI", 12, FontStyle.Bold);

                // Màu sắc theo phong cách Flat Design (Xanh dương hiện đại)
                btn.BackColor = Color.FromArgb(52, 152, 219);
                btn.ForeColor = Color.White; // Chữ màu trắng

                // Bỏ viền 3D cũ kỹ đi
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;

                // Lưu số thứ tự
                btn.Tag = i;

                // --- PHẦN HIỆU ỨNG TƯƠNG TÁC (QUAN TRỌNG) ---

                // Khi rê chuột vào: Đổi màu đậm hơn + hiện bàn tay
                btn.MouseEnter += (s, e) => {
                    Button b = s as Button;
                    b.BackColor = Color.FromArgb(41, 128, 185); // Xanh đậm hơn
                    b.Cursor = Cursors.Hand; // Hiện hình bàn tay
                    // Hiệu ứng nở ra một chút (Optional)
                    b.Size = new Size(124, 64);
                    b.Location = new Point(b.Location.X - 2, b.Location.Y - 2);
                };

                // Khi chuột rời ra: Trả về màu cũ
                btn.MouseLeave += (s, e) => {
                    Button b = s as Button;
                    b.BackColor = Color.FromArgb(52, 152, 219); // Về màu gốc
                    b.Size = new Size(120, 60); // Về kích thước gốc
                    b.Location = new Point(b.Location.X + 2, b.Location.Y + 2);
                };

                // Gắn sự kiện Click
                btn.Click += BamVaoBai;

                // Thêm vào bảng
                pnlDanhSachBai.Controls.Add(btn);
            }
        }

        // Hàm xử lý khi bấm vào nút
        // Hàm xử lý khi bấm vào nút
        // Hàm xử lý khi bấm vào nút
        void BamVaoBai(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int baiSo = (int)btn.Tag;

            string tenForm = "FormBai" + baiSo;

            string nameSpace = this.GetType().Namespace;

            // Ghép lại: TênNamespace.TenForm (Ví dụ: CaoQuangNhat_2123110077_1_.FormBai1)
            Type type = Type.GetType(nameSpace + "." + tenForm);

            if (type != null)
            {
                Form f = (Form)Activator.CreateInstance(type);
                f.StartPosition = FormStartPosition.CenterScreen;
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chưa tìm thấy " + tenForm + "\n(" + nameSpace + "." + tenForm + ")");
            }
        }
    }
}