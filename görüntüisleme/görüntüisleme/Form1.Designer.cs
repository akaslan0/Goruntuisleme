
namespace görüntüisleme
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pikselAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parlaklıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.griYöntemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thresholdYöntemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ikiliGörüntüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(294, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pikselAlToolStripMenuItem,
            this.invertToolStripMenuItem,
            this.parlaklıkToolStripMenuItem,
            this.griYöntemleriToolStripMenuItem,
            this.thresholdYöntemleriToolStripMenuItem,
            this.ikiliGörüntüToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.işlemlerToolStripMenuItem.Text = "işlemler";
            // 
            // pikselAlToolStripMenuItem
            // 
            this.pikselAlToolStripMenuItem.Name = "pikselAlToolStripMenuItem";
            this.pikselAlToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.pikselAlToolStripMenuItem.Text = "piksel al";
            this.pikselAlToolStripMenuItem.Click += new System.EventHandler(this.pikselAlToolStripMenuItem_Click);
            // 
            // invertToolStripMenuItem
            // 
            this.invertToolStripMenuItem.Name = "invertToolStripMenuItem";
            this.invertToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.invertToolStripMenuItem.Text = "invert";
            this.invertToolStripMenuItem.Click += new System.EventHandler(this.invertToolStripMenuItem_Click);
            // 
            // parlaklıkToolStripMenuItem
            // 
            this.parlaklıkToolStripMenuItem.Name = "parlaklıkToolStripMenuItem";
            this.parlaklıkToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.parlaklıkToolStripMenuItem.Text = "parlaklık";
            this.parlaklıkToolStripMenuItem.Click += new System.EventHandler(this.parlaklıkToolStripMenuItem_Click);
            // 
            // griYöntemleriToolStripMenuItem
            // 
            this.griYöntemleriToolStripMenuItem.Name = "griYöntemleriToolStripMenuItem";
            this.griYöntemleriToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.griYöntemleriToolStripMenuItem.Text = "gri yöntemleri";
            this.griYöntemleriToolStripMenuItem.Click += new System.EventHandler(this.griYöntemleriToolStripMenuItem_Click);
            // 
            // thresholdYöntemleriToolStripMenuItem
            // 
            this.thresholdYöntemleriToolStripMenuItem.Name = "thresholdYöntemleriToolStripMenuItem";
            this.thresholdYöntemleriToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.thresholdYöntemleriToolStripMenuItem.Text = "threshold yöntemleri";
            this.thresholdYöntemleriToolStripMenuItem.Click += new System.EventHandler(this.thresholdYöntemleriToolStripMenuItem_Click);
            // 
            // ikiliGörüntüToolStripMenuItem
            // 
            this.ikiliGörüntüToolStripMenuItem.Name = "ikiliGörüntüToolStripMenuItem";
            this.ikiliGörüntüToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.ikiliGörüntüToolStripMenuItem.Text = " ikili goruntu islemleri";
            this.ikiliGörüntüToolStripMenuItem.Click += new System.EventHandler(this.ikiliGörüntüToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 288);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pikselAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parlaklıkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem griYöntemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thresholdYöntemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ikiliGörüntüToolStripMenuItem;
    }
}

