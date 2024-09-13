namespace volume_kubus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sisi = int.Parse(txtsisi.Text);
            int volume = (int)Math.Pow((double)sisi, 3.0);
            txtvolume.Text = volume.ToString();
            lblvolume.Visible = true;
            txtvolume.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtsisi.Text = "";
            lblvolume.Visible = false;
            txtvolume.Visible = false;
        }
    }
}