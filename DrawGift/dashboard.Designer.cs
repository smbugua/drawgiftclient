﻿namespace DrawGift
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.raffleEntriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raffleEntryDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addShopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shopDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editShopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Wheat;
            this.statusStrip1.Location = new System.Drawing.Point(0, 563);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1029, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raffleEntriesToolStripMenuItem,
            this.shopToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1029, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // raffleEntriesToolStripMenuItem
            // 
            this.raffleEntriesToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("raffleEntriesToolStripMenuItem.BackgroundImage")));
            this.raffleEntriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEntryToolStripMenuItem,
            this.raffleEntryDetailsToolStripMenuItem});
            this.raffleEntriesToolStripMenuItem.Name = "raffleEntriesToolStripMenuItem";
            this.raffleEntriesToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.raffleEntriesToolStripMenuItem.Text = "Raffle Entries";
            // 
            // addEntryToolStripMenuItem
            // 
            this.addEntryToolStripMenuItem.Name = "addEntryToolStripMenuItem";
            this.addEntryToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.addEntryToolStripMenuItem.Text = "Add Entry";
            this.addEntryToolStripMenuItem.Click += new System.EventHandler(this.addEntryToolStripMenuItem_Click);
            // 
            // raffleEntryDetailsToolStripMenuItem
            // 
            this.raffleEntryDetailsToolStripMenuItem.Name = "raffleEntryDetailsToolStripMenuItem";
            this.raffleEntryDetailsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.raffleEntryDetailsToolStripMenuItem.Text = "Raffle Entry Details";
            this.raffleEntryDetailsToolStripMenuItem.Click += new System.EventHandler(this.raffleEntryDetailsToolStripMenuItem_Click);
            // 
            // shopToolStripMenuItem
            // 
            this.shopToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addShopToolStripMenuItem,
            this.shopDetailsToolStripMenuItem,
            this.editShopToolStripMenuItem});
            this.shopToolStripMenuItem.Enabled = false;
            this.shopToolStripMenuItem.Name = "shopToolStripMenuItem";
            this.shopToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.shopToolStripMenuItem.Text = "Shop";
            // 
            // addShopToolStripMenuItem
            // 
            this.addShopToolStripMenuItem.Name = "addShopToolStripMenuItem";
            this.addShopToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.addShopToolStripMenuItem.Text = "Add Shop";
            this.addShopToolStripMenuItem.Click += new System.EventHandler(this.addShopToolStripMenuItem_Click);
            // 
            // shopDetailsToolStripMenuItem
            // 
            this.shopDetailsToolStripMenuItem.Name = "shopDetailsToolStripMenuItem";
            this.shopDetailsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.shopDetailsToolStripMenuItem.Text = "Shop Details";
            this.shopDetailsToolStripMenuItem.Click += new System.EventHandler(this.shopDetailsToolStripMenuItem_Click);
            // 
            // editShopToolStripMenuItem
            // 
            this.editShopToolStripMenuItem.Name = "editShopToolStripMenuItem";
            this.editShopToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.editShopToolStripMenuItem.Text = "Edit Shop";
            this.editShopToolStripMenuItem.Click += new System.EventHandler(this.editShopToolStripMenuItem_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1029, 585);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "dashboard";
            this.Text = "GALLERIA SHOPPING MALL RAFFLE DRAW SOLUTION";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem raffleEntriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raffleEntryDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addShopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shopDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editShopToolStripMenuItem;
    }
}

