using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novellaoop
{
    public partial class Unicorn : Form
    {
        public Unicorn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            winwin winwin = new winwin();
            winwin.Show();
        }
    }
}
