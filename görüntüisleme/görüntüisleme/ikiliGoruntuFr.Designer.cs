
namespace görüntüisleme
{
    partial class ikiliGoruntuFr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görüntüAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ikiliGörüntüİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toplamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkarmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.islemBox = new System.Windows.Forms.PictureBox();
            this.KaynakBox1 = new System.Windows.Forms.PictureBox();
            this.KaynakBox2 = new System.Windows.Forms.PictureBox();
            this.intersectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.differenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.islemBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KaynakBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KaynakBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.ikiliGörüntüİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1717, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem,
            this.görüntüAçToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.dosyaToolStripMenuItem.Text = "dosya";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.açToolStripMenuItem.Text = "1. görüntü aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click_1);
            // 
            // görüntüAçToolStripMenuItem
            // 
            this.görüntüAçToolStripMenuItem.Name = "görüntüAçToolStripMenuItem";
            this.görüntüAçToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.görüntüAçToolStripMenuItem.Text = "2. görüntü aç";
            this.görüntüAçToolStripMenuItem.Click += new System.EventHandler(this.görüntüAçToolStripMenuItem_Click);
            // 
            // ikiliGörüntüİşlemleriToolStripMenuItem
            // 
            this.ikiliGörüntüİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toplamaToolStripMenuItem,
            this.çıkarmaToolStripMenuItem,
            this.intersectToolStripMenuItem,
            this.differenceToolStripMenuItem,
            this.mergeToolStripMenuItem});
            this.ikiliGörüntüİşlemleriToolStripMenuItem.Name = "ikiliGörüntüİşlemleriToolStripMenuItem";
            this.ikiliGörüntüİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.ikiliGörüntüİşlemleriToolStripMenuItem.Text = "ikili görüntü işlemleri";
            // 
            // toplamaToolStripMenuItem
            // 
            this.toplamaToolStripMenuItem.Name = "toplamaToolStripMenuItem";
            this.toplamaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.toplamaToolStripMenuItem.Text = "toplama";
            this.toplamaToolStripMenuItem.Click += new System.EventHandler(this.toplamaToolStripMenuItem_Click);
            // 
            // çıkarmaToolStripMenuItem
            // 
            this.çıkarmaToolStripMenuItem.Name = "çıkarmaToolStripMenuItem";
            this.çıkarmaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.çıkarmaToolStripMenuItem.Text = "çıkarma";
            this.çıkarmaToolStripMenuItem.Click += new System.EventHandler(this.çıkarmaToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // islemBox
            // 
            this.islemBox.Location = new System.Drawing.Point(1106, 61);
            this.islemBox.Name = "islemBox";
            this.islemBox.Size = new System.Drawing.Size(476, 448);
            this.islemBox.TabIndex = 7;
            this.islemBox.TabStop = false;
            // 
            // KaynakBox1
            // 
            this.KaynakBox1.Location = new System.Drawing.Point(12, 61);
            this.KaynakBox1.Name = "KaynakBox1";
            this.KaynakBox1.Size = new System.Drawing.Size(496, 448);
            this.KaynakBox1.TabIndex = 6;
            this.KaynakBox1.TabStop = false;
            this.KaynakBox1.Click += new System.EventHandler(this.KaynakBox1_Click);
            // 
            // KaynakBox2
            // 
            this.KaynakBox2.Location = new System.Drawing.Point(560, 61);
            this.KaynakBox2.Name = "KaynakBox2";
            this.KaynakBox2.Size = new System.Drawing.Size(496, 448);
            this.KaynakBox2.TabIndex = 8;
            this.KaynakBox2.TabStop = false;
            // 
            // intersectToolStripMenuItem
            // 
            this.intersectToolStripMenuItem.Name = "intersectToolStripMenuItem";
            this.intersectToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.intersectToolStripMenuItem.Text = "intersect";
            this.intersectToolStripMenuItem.Click += new System.EventHandler(this.intersectToolStripMenuItem_Click);
            // 
            // differenceToolStripMenuItem
            // 
            this.differenceToolStripMenuItem.Name = "differenceToolStripMenuItem";
            this.differenceToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.differenceToolStripMenuItem.Text = "difference";
            this.differenceToolStripMenuItem.Click += new System.EventHandler(this.differenceToolStripMenuItem_Click);
            // 
            // mergeToolStripMenuItem
            // 
            this.mergeToolStripMenuItem.Name = "mergeToolStripMenuItem";
            this.mergeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mergeToolStripMenuItem.Text = "merge";
            this.mergeToolStripMenuItem.Click += new System.EventHandler(this.mergeToolStripMenuItem_Click);
            // 
            // ikiliGoruntuFr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1717, 747);
            this.Controls.Add(this.KaynakBox2);
            this.Controls.Add(this.islemBox);
            this.Controls.Add(this.KaynakBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ikiliGoruntuFr";
            this.Text = "ikiliGoruntu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.islemBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KaynakBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KaynakBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ikiliGörüntüİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toplamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkarmaToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox islemBox;
        private System.Windows.Forms.PictureBox KaynakBox1;
        private System.Windows.Forms.PictureBox KaynakBox2;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem görüntüAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intersectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem differenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mergeToolStripMenuItem;
    }
}