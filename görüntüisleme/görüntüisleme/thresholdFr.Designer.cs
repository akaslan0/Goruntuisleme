
namespace görüntüisleme
{
    partial class thresholdFr
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tresholdYöntemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elleDeğerGirmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KaynakBox1 = new System.Windows.Forms.PictureBox();
            this.islemBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KaynakBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.tresholdYöntemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1096, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.dosyaToolStripMenuItem.Text = "dosya";
            // 
            // tresholdYöntemleriToolStripMenuItem
            // 
            this.tresholdYöntemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elleDeğerGirmeToolStripMenuItem});
            this.tresholdYöntemleriToolStripMenuItem.Name = "tresholdYöntemleriToolStripMenuItem";
            this.tresholdYöntemleriToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.tresholdYöntemleriToolStripMenuItem.Text = "treshold yöntemleri";
            // 
            // elleDeğerGirmeToolStripMenuItem
            // 
            this.elleDeğerGirmeToolStripMenuItem.Name = "elleDeğerGirmeToolStripMenuItem";
            this.elleDeğerGirmeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.elleDeğerGirmeToolStripMenuItem.Text = "elle değer girme";
            this.elleDeğerGirmeToolStripMenuItem.Click += new System.EventHandler(this.elleDeğerGirmeToolStripMenuItem_Click);
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.açToolStripMenuItem.Text = "aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // KaynakBox1
            // 
            this.KaynakBox1.Location = new System.Drawing.Point(12, 53);
            this.KaynakBox1.Name = "KaynakBox1";
            this.KaynakBox1.Size = new System.Drawing.Size(496, 448);
            this.KaynakBox1.TabIndex = 7;
            this.KaynakBox1.TabStop = false;
            // 
            // islemBox
            // 
            this.islemBox.Location = new System.Drawing.Point(571, 53);
            this.islemBox.Name = "islemBox";
            this.islemBox.Size = new System.Drawing.Size(476, 448);
            this.islemBox.TabIndex = 8;
            this.islemBox.TabStop = false;
            // 
            // thresholdFr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 513);
            this.Controls.Add(this.islemBox);
            this.Controls.Add(this.KaynakBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "thresholdFr";
            this.Text = "thresholdFr";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KaynakBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tresholdYöntemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elleDeğerGirmeToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.PictureBox KaynakBox1;
        private System.Windows.Forms.PictureBox islemBox;
    }
}