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
    public partial class les : Form
    {
        public les()
        {
            InitializeComponent();
        }

        private void right_Click(object sender, EventArgs e)
        {
            lose2 l2 = new lose2();
            l2.Show();
        }

        private void left_Click(object sender, EventArgs e)
        {
            Unicorn unicorn = new Unicorn(); 
            unicorn.Show();
        }
    }
}
