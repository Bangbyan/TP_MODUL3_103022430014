namespace TP_MODUL3_103022430014
{
    public partial class Form1 : Form
    {
        private long hasilSekarang = 0;
        private string input = "";

        public Form1()
        {
            InitializeComponent();

            labelOutput.Text = "0";

            btn1.Click += btnAngka_Click;
            btn2.Click += btnAngka_Click;
            btn3.Click += btnAngka_Click;
            btn4.Click += btnAngka_Click;
            btn5.Click += btnAngka_Click;
            btn6.Click += btnAngka_Click;
            btn7.Click += btnAngka_Click;
            btn8.Click += btnAngka_Click;
            btn9.Click += btnAngka_Click;
            btn0.Click += btnAngka_Click;

            btn_tambah.Click += btnPlus_Click;
            btn_samadengan.Click += btnEqual_Click;
        }

        private void btnAngka_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (input == "0") input = "";

            input += btn.Text;
            labelOutput.Text = input;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(input))
            {
                hasilSekarang += long.Parse(input);
                input = "";
                labelOutput.Text = "0";
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(input))
            {
                hasilSekarang += long.Parse(input);
                labelOutput.Text = hasilSekarang.ToString();

                input = hasilSekarang.ToString();
                hasilSekarang = 0;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}