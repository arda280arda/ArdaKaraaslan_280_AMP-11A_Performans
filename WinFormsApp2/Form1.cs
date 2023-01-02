namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        timer1.Start();   
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rd = new Random();
            pictureBox1.Left += rd.Next(5,25);
            pictureBox2.Left += rd.Next(5, 25);
            pictureBox3.Left += rd.Next(5, 25);
            if (pictureBox1.Left > label1.Left)
            {
                timer1.Stop();
                MessageBox.Show("1. kazandý");
            }
            else if (pictureBox2.Left > label1.Left)
            {
                timer1.Stop();
                MessageBox.Show("2. kazandý");
            }
            else if (pictureBox3.Left > label1.Left)
            {
                timer1.Stop();
                MessageBox.Show("3. kazandý");
            }
        }
    }
}