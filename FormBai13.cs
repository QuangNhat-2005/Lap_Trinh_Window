using System;
using System.Collections; // Dùng cho ArrayList
using System.Windows.Forms;

namespace CaoQuangNhat_2123110077_1_
{
    // --- LƯU Ý QUAN TRỌNG: Class Form phải nằm trên cùng để mở được giao diện ---
    public partial class FormBai13 : Form
    {
        public FormBai13()
        {
            InitializeComponent();
        }

        // 1. Hàm tạo dữ liệu giả (Theo Slide 100)
        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();

            Faculty f = new Faculty();
            f.Id = "K01";
            f.Name = "Công nghệ thông tin";
            f.Quantity = 1200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K02";
            f.Name = "Quản trị kinh doanh";
            f.Quantity = 4200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K03";
            f.Name = "Kế toán tài chính";
            f.Quantity = 5200;
            lst.Add(f);

            return lst;
        }

        // 2. Sự kiện Form Load (Khi mở lên)
        private void FormBai13_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();
            cb_Faculty.DataSource = lst;
            cb_Faculty.DisplayMember = "Name"; // Hiện Tên khoa ra ngoài
        }

        // 3. Sự kiện khi chọn thay đổi
        private void cb_Faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Khi chọn thì lấy Mã khoa (Id)
            cb_Faculty.ValueMember = "Id";

            // Kiểm tra null để tránh lỗi khi vừa reset
            if (cb_Faculty.SelectedValue != null)
            {
                string id = cb_Faculty.SelectedValue.ToString();
                tbDisplay.Text = "Bạn đã chọn khoa có mã: " + id;
            }
        }

        // 4. Sự kiện bấm nút OK
        private void btOK_Click(object sender, EventArgs e)
        {
            // Khi bấm OK thì lấy Tên khoa (Name)
            cb_Faculty.ValueMember = "Name";

            if (cb_Faculty.SelectedValue != null)
            {
                string name = cb_Faculty.SelectedValue.ToString();
                tbDisplay.Text = "Bạn đã chọn khoa có tên: " + name;
            }
        }

        // 5. Sự kiện bấm nút CLEAR (Mới thêm)
        private void btClear_Click(object sender, EventArgs e)
        {
            // Xóa chữ trên màn hình
            tbDisplay.Text = "";

            // Reset ComboBox về trạng thái chưa chọn gì cả (tùy chọn)
            // cb_Faculty.SelectedIndex = -1; 

            // Hoặc đưa con trỏ về ô nhập liệu (nếu có)
            MessageBox.Show("Đã xóa màn hình!");
        }
    }

    // --- Class Faculty nằm ở dưới cùng (Để không bị lỗi Designer) ---
    public class Faculty
    {
        // Thêm giá trị mặc định = "" để tránh cảnh báo vàng (Null Warning)
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public int Quantity { get; set; }
    }
}