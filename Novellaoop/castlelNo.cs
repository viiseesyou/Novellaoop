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
    public partial class castlelNo : Form
    {
        public castlelNo()
        {
            InitializeComponent();
        }

        private void lose1_Click(object sender, EventArgs e)
        {
            goblin goblin = new goblin();
            goblin.Show();
        }
    }
}
