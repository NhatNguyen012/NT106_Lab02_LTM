namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_BT1_Click(object sender, EventArgs e)
        {
            BT1 form = new BT1();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btn_BT2_Click(object sender, EventArgs e)
        {
            BT2 form = new BT2();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
        private void btn_BT4_Click(object sender, EventArgs e)
        {
            BT4 form = new BT4();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
        private void btn_BT3_Click(object sender, EventArgs e)
        {
            BT3 form = new BT3();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btn_BT5_Click(object sender, EventArgs e)
        {
            BT5 form = new BT5();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
