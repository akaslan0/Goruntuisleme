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
    public partial class invertFr : Form
    {
        Bitmap kaynak, islem;
        public invertFr()
        {
            InitializeComponent();
        }

        private void uygulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++) 
            {
                for (int x = 0; x < gen; x++)
                {
                    Color piksel = kaynak.GetPixel(x, y);
                    Color yenipiksel = Color.FromArgb(255 - piksel.R, 255 - piksel.G, 255 - piksel.B);
                    islem.SetPixel(x, y, yenipiksel);

                }
            }

            islemBox.Image = islem;

        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) 
            {
                kaynak = new Bitmap(openFileDialog1.FileName);
                KaynakBox1.Image = kaynak;
            }
        }
    }
}
