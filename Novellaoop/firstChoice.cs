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
    public partial class firstChoice : Form
    {
        public firstChoice()
        {
            InitializeComponent();
        }

        private void castle_Click(object sender, EventArgs e)
        {
            castle castleF = new castle();
            castleF.Show();

        }

        private void forest_Click(object sender, EventArgs e)
        {
            les les = new les();
            les.Show();
        }
    }
}
