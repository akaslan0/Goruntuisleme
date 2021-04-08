﻿using System;
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
    public partial class PikselFr : Form
    {
        Bitmap kaynak; //bos bir görüntu tanımladık
        public PikselFr()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);

            Color renk = kaynak.GetPixel(x, y);
            pictureBox1.BackColor = renk;

            Console.WriteLine(renk.R + "-" + renk.G + "-" + renk.B);// alınan renklerın rgb degerlerini gösterdik
        }
    }
}
