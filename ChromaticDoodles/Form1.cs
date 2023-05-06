namespace ChromaticDoodles
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.Cyan;
            pictureBox2.BackColor = Color.Magenta;
            pictureBox3.BackColor = Color.Yellow;
            pictureBox4.BackColor = Color.Black;

        }
      
        public event EventHandler ButtonClicked;
        
        public void pictureBox5_Click(object sender, EventArgs e)
        {
            if (ButtonClicked != null)
             ButtonClicked(sender, e);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            this.Parent = null;
        }
    }
}
