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
    public partial class grıFr : Form
    {
        Bitmap kaynak, islem;
        public grıFr()
        {
            InitializeComponent();
        }

        private void ortalamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color piksel = kaynak.GetPixel(x, y);
                    int  griDeger = (piksel.R + piksel.G + piksel.B) / 3;
                    Color griPiksel = Color.FromArgb(griDeger, griDeger, griDeger);
                    islem.SetPixel(x, y, griPiksel);
                }
            }

            islemBox.Image = islem;

        }

        private void bT709ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++) 
            {
                for (int x = 0; x < gen; x++) 
                {
                    Color piksel = kaynak.GetPixel(x, y);
                    int griDeger= Convert.ToInt32(piksel.R* 0.2125 + piksel.G * 0.7154 + piksel.B*0.072) ;
                    Color  griPiksel = Color.FromArgb(griDeger, griDeger, griDeger);
                    islem.SetPixel(x,y,griPiksel);
                }
            }

            islemBox.Image = islem;

        }

        private void lumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color piksel = kaynak.GetPixel(x, y);
                    int griDeger = Convert.ToInt32(piksel.R * 0.3 + piksel.G * 0.59 + piksel.B * 0.11);
                    Color griPiksel = Color.FromArgb( griDeger,griDeger, griDeger);
                    islem.SetPixel(x, y, griPiksel);
                }
            }

            islemBox.Image = islem;

        }

        private void açıklıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            int MaxgriDeger=0;
            int MingriDeger=0;
            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color piksel = kaynak.GetPixel(x, y);
                    if (piksel.R > piksel.G & piksel.R > piksel.B)
                    {
                        MaxgriDeger = piksel.R;
                    }
                    if (piksel.G > piksel.R & piksel.G > piksel.B)
                    {
                        MaxgriDeger = piksel.G;
                    }
                    if (piksel.B > piksel.R & piksel.B > piksel.G)
                    {
                         MaxgriDeger = piksel.B;
                    }

                    if (piksel.R < piksel.G & piksel.R < piksel.B)
                    {
                        MingriDeger = piksel.R;
                    }
                     if (piksel.G < piksel.R & piksel.G < piksel.B)
                    {
                        MingriDeger = piksel.G;
                    }
                    if (piksel.B < piksel.R & piksel.B < piksel.G)
                    {
                        MingriDeger = piksel.B;
                    }

                    int griDeger =( MaxgriDeger + MingriDeger)/2;
                    Color griPiksel = Color.FromArgb(griDeger, griDeger, griDeger);
                    islem.SetPixel(x, y, griPiksel);
                }
            }

            islemBox.Image = islem;
        }

        private void renkKanalıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color piksel = kaynak.GetPixel(x, y);
                    int griDeger = Convert.ToInt32(piksel.R);
                    Color griPiksel = Color.FromArgb(piksel.R,piksel.R, piksel.R);
                    islem.SetPixel(x, y, griPiksel);
                }
            }

            islemBox.Image = islem;
        }

        private void normalizeEdilmisRenkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            int  Ir;
            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color piksel = kaynak.GetPixel(x, y);
                    int griDeger = (piksel.R + piksel.G + piksel.B) ;
                    if (griDeger == 0)
                    {
                        Ir = 0;
                    }
                    else
                    {
                        Ir = 255 * piksel.R / griDeger;
                    }

                    Color griPiksel = Color.FromArgb(Ir,Ir,Ir);
                    islem.SetPixel(x, y, griPiksel);
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
