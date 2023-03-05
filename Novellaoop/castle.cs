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
    public partial class castle : Form
    {
        public castle()
        {
            InitializeComponent();
        }

        private void No1_Click(object sender, EventArgs e)
        {
            castlelNo cN = new castlelNo();
            cN.Show();
        }

        private void Yes1_Click(object sender, EventArgs e)
        {
            CastleInside castleInside = new CastleInside();
            castleInside.Show();
        }
    }
}
