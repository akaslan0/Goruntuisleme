using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace görüntüisleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pikselAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PikselFr pikselFormu = new PikselFr();
            pikselFormu.ShowDialog();
        }

        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            invertFr invertFormu = new invertFr();
            invertFormu.ShowDialog();
        }

        private void parlaklıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parlaklıkFr parlaklıkFormu = new parlaklıkFr();
            parlaklıkFormu.ShowDialog();
        }

        private void griYöntemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grıFr griFormu = new grıFr();
            griFormu.ShowDialog();



        }
    }
}
