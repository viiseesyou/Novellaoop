namespace Novellaoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            firstChoice choice1 = new firstChoice();
            choice1.Show();
        }
    }
}