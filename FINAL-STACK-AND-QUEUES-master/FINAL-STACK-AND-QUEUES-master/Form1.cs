namespace FINAL_STACK_AND_QUEUES
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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Queue h = new Queue();
            this.Hide();
            h.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stack h = new Stack();
            this.Hide();
            h.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
