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
    public partial class CastleInside : Form
    {
        public CastleInside()
        {
            InitializeComponent();
        }

        private void gothere_Click(object sender, EventArgs e)
        {
            villainy villainy = new villainy();
            villainy.Show();
        }

        private void dontgo_Click(object sender, EventArgs e)
        {
            les les = new les();
            les.Show();
        }
    }
}
