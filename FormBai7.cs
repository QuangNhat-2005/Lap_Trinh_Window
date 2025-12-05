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
    public partial class FormBai7 : Form
    {
        public FormBai7()
        {
            InitializeComponent();
        }

        private void tbYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra: Nếu KHÔNG PHẢI phím chức năng (như Backspace) 
            // VÀ cũng KHÔNG PHẢI là số (Digit)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Thì chặn lại, không cho hiện ra
                e.Handled = true;
            }
        }

        private void tbYear_Validating(object sender, CancelEventArgs e)
        {
            // Chuyển chữ thành số để so sánh
            // (Lưu ý: Nếu để trống mà thoát ra sẽ bị lỗi, nhưng tạm thời làm theo slide)
            if (tbYear.Text.Length > 0)
            {
                int year = int.Parse(tbYear.Text);

                // Nếu năm lớn hơn 2000
                if (year > 2000)
                {
                    // Cancel = true nghĩa là "Giữ chân lại", không cho trỏ chuột đi chỗ khác
                    e.Cancel = true;
                    MessageBox.Show("Năm phải nhỏ hơn hoặc bằng 2000!");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
