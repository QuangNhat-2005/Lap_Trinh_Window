using System;
using System.Windows.Forms;

namespace CaoQuangNhat_2123110077_1_
{
    public partial class FormBai11 : Form
    {
        // 1. Khai báo biến bộ nhớ (Theo Slide 83)
        decimal memory = 0;         // Biến nhớ (cho M+, M-)
        decimal workingMemory = 0;  // Biến lưu số thứ nhất (cho +, -...)
        string opr = "";            // Biến lưu phép toán

        public FormBai11()
        {
            InitializeComponent();
        }

        // 2. Hàm xử lý chung cho TẤT CẢ các nút (Theo Slide 84 -> 90)
        private void Button_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender; // Lấy cái nút vừa được bấm

            // --- NHÓM 1: Nút Số và Dấu chấm ---
            if ((char.IsDigit(bt.Text, 0) && bt.Text.Length == 1) || bt.Text == ".")
            {
                // [VALIDATION MỚI] Kiểm tra chặn dấu chấm thứ 2
                if (bt.Text == ".")
                {
                    // Nếu màn hình đã có dấu chấm rồi -> Dừng lại, không làm gì cả
                    if (txtDisplay.Text.Contains("."))
                    {
                        return;
                    }
                }

                // Nếu màn hình đang chặn (do vừa bấm phép tính xong) thì xóa đi nhập mới
                // (Logic này nâng cao, tạm thời làm đơn giản là nối chuỗi như slide)
                txtDisplay.Text += bt.Text;
            }

            // --- NHÓM 2: Phép tính cơ bản (+, -, *, /) ---
            else if (bt.Text == "*" || bt.Text == "/" || bt.Text == "+" || bt.Text == "-")
            {
                opr = bt.Text;
                workingMemory = decimal.Parse(txtDisplay.Text);
                txtDisplay.Clear();
            }

            // --- NHÓM 3: Nút BẰNG (=) ---
            else if (bt.Text == "=")
            {
                decimal secondValue = decimal.Parse(txtDisplay.Text);
                switch (opr)
                {
                    case "+": txtDisplay.Text = (workingMemory + secondValue).ToString(); break;
                    case "-": txtDisplay.Text = (workingMemory - secondValue).ToString(); break;
                    case "*": txtDisplay.Text = (workingMemory * secondValue).ToString(); break;
                    case "/":
                        // Tránh lỗi chia cho 0
                        if (secondValue != 0)
                            txtDisplay.Text = (workingMemory / secondValue).ToString();
                        else
                            MessageBox.Show("Không thể chia cho 0");
                        break;
                }
            }

            // --- NHÓM 4: Các phép tính một ngôi (±, √, %, 1/x) ---
            else if (bt.Text == "±")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                currVal = -currVal; // Đổi dấu
                txtDisplay.Text = currVal.ToString();
            }
            else if (bt.Text == "√")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                if (currVal >= 0)
                    txtDisplay.Text = ((decimal)Math.Sqrt((double)currVal)).ToString();
            }
            else if (bt.Text == "%")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                txtDisplay.Text = (currVal / 100).ToString();
            }
            else if (bt.Text == "1/x")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                txtDisplay.Text = (1 / currVal).ToString();
            }

            // --- NHÓM 5: Xóa (←, CE, C) ---
            else if (bt.Text == "←") // Nút Backspace
            {
                if (txtDisplay.TextLength != 0)
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.TextLength - 1);
            }
            else if (bt.Text == "C")
            {
                workingMemory = 0;
                opr = "";
                txtDisplay.Clear();
            }
            else if (bt.Text == "CE")
            {
                txtDisplay.Clear();
            }

            // --- NHÓM 6: Bộ nhớ (MC, MR, MS, M+, M-) ---
            else if (bt.Text == "MC") memory = 0;
            else if (bt.Text == "MR") txtDisplay.Text = memory.ToString();
            else if (bt.Text == "MS") { memory = decimal.Parse(txtDisplay.Text); txtDisplay.Clear(); }
            else if (bt.Text == "M+") { memory = memory + decimal.Parse(txtDisplay.Text); }
            else if (bt.Text == "M-") { memory = memory - decimal.Parse(txtDisplay.Text); }
        }
    }
}