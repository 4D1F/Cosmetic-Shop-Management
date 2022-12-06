namespace CosmeticShopManagementSystemCSharp
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ViewInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CosmeticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.BackColor = System.Drawing.Color.Plum;
            this.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MenuStrip1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewInformationToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(961, 39);
            this.MenuStrip1.TabIndex = 1;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // ViewInformationToolStripMenuItem
            // 
            this.ViewInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CosmeticsToolStripMenuItem});
            this.ViewInformationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ViewInformationToolStripMenuItem.Name = "ViewInformationToolStripMenuItem";
            this.ViewInformationToolStripMenuItem.Size = new System.Drawing.Size(237, 35);
            this.ViewInformationToolStripMenuItem.Text = "View Information";
            // 
            // CosmeticsToolStripMenuItem
            // 
            this.CosmeticsToolStripMenuItem.Name = "CosmeticsToolStripMenuItem";
            this.CosmeticsToolStripMenuItem.Size = new System.Drawing.Size(206, 36);
            this.CosmeticsToolStripMenuItem.Text = "Cosmetics";
            this.CosmeticsToolStripMenuItem.Click += new System.EventHandler(this.CosmeticsToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ExitToolStripMenuItem.AutoToolTip = true;
            this.ExitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(88, 35);
            this.ExitToolStripMenuItem.Text = "Login";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(961, 561);
            this.Controls.Add(this.MenuStrip1);
            this.Name = "MainPage";
            this.Text = "Home";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem ViewInformationToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CosmeticsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
    }
}