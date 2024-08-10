namespace Tính_toán
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Tong_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt_so1.Text);
            int b = int.Parse(txt_so2.Text);
            int Tong = a + b;
            txt_ketQua.Text = Tong.ToString();
        }

        private void btn_tich_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt_so1.Text);
            int b = int.Parse(txt_so2.Text);
            int Tich = a * b;
            txt_ketQua.Text = Tich.ToString();
        }

        private void txt_giaiThua_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_giaiThua.Text))
            {
                if (int.TryParse(txt_giaiThua.Text, out int a))
                {
                    int GiaiThua = 1;
                    for (int i = 1; i <= a; i++)
                    {
                        GiaiThua *= i;
                    }
                    txt_ketquagiathua.Text = GiaiThua.ToString();
                }
                else
                {
                    // Hiển thị thông báo lỗi hoặc xử lý khi đầu vào không hợp lệ
                    txt_ketquagiathua.Text = "Invalid input";
                }
            }
            else
            {
                txt_giaiThua.Text = "1";
                txt_ketquagiathua.Text = "1";
            }
        }
    }
}
