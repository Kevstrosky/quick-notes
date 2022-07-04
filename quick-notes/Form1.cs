namespace quick_notes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 equipos = new Form2();
            equipos.Show();
            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 garantias = new Form3();
            garantias.Show();
            this.Hide();

        }
    }
}