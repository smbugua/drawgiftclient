﻿namespace DrawGift.raffle
{
    partial class entry
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(entry));
            this.shopBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.shopsDataSet = new Drawgift_Client.shopsDataSet();
            this.shopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drawgiftDataSet = new DrawGift.drawgiftDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.birth = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.datea = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pass = new System.Windows.Forms.TextBox();
            this.area = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.TextBox();
            this.idno = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.shopTableAdapter = new DrawGift.drawgiftDataSetTableAdapters.shopTableAdapter();
            this.customerTableAdapter = new DrawGift.drawgiftDataSetTableAdapters.customerTableAdapter();
            this.shopTableAdapter1 = new Drawgift_Client.shopsDataSetTableAdapters.shopTableAdapter();
            this.Shop = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vouchers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawgiftDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // shopBindingSource1
            // 
            this.shopBindingSource1.DataMember = "shop";
            this.shopBindingSource1.DataSource = this.shopsDataSet;
            // 
            // shopsDataSet
            // 
            this.shopsDataSet.DataSetName = "shopsDataSet";
            this.shopsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shopBindingSource
            // 
            this.shopBindingSource.DataMember = "shop";
            this.shopBindingSource.DataSource = this.drawgiftDataSet;
            // 
            // drawgiftDataSet
            // 
            this.drawgiftDataSet.DataSetName = "drawgiftDataSet";
            this.drawgiftDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.drawgiftDataSet;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainer1.Panel1.Controls.Add(this.birth);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.gender);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.checkBox1);
            this.splitContainer1.Panel1.Controls.Add(this.datea);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.pass);
            this.splitContainer1.Panel1.Controls.Add(this.area);
            this.splitContainer1.Panel1.Controls.Add(this.name);
            this.splitContainer1.Panel1.Controls.Add(this.tel);
            this.splitContainer1.Panel1.Controls.Add(this.idno);
            this.splitContainer1.Panel1.Controls.Add(this.save);
            this.splitContainer1.Panel1.Controls.Add(this.search);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1071, 718);
            this.splitContainer1.SplitterDistance = 310;
            this.splitContainer1.TabIndex = 1;
            // 
            // birth
            // 
            this.birth.CustomFormat = "yyyy/M/dd";
            this.birth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birth.Location = new System.Drawing.Point(169, 372);
            this.birth.Name = "birth";
            this.birth.Size = new System.Drawing.Size(138, 31);
            this.birth.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(165, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "DOB";
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender.Location = new System.Drawing.Point(16, 372);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(140, 31);
            this.gender.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Gender";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(148, 255);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(118, 27);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "New Entry?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // datea
            // 
            this.datea.CustomFormat = "yyyy/M/dd";
            this.datea.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datea.Location = new System.Drawing.Point(17, 619);
            this.datea.Name = "datea";
            this.datea.Size = new System.Drawing.Size(200, 31);
            this.datea.TabIndex = 16;
            this.datea.ValueChanged += new System.EventHandler(this.datea_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 585);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Date";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 669);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(17, 536);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(267, 31);
            this.pass.TabIndex = 13;
            this.pass.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // area
            // 
            this.area.Location = new System.Drawing.Point(17, 459);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(269, 31);
            this.area.TabIndex = 12;
            this.area.TextChanged += new System.EventHandler(this.area_TextChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(18, 291);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(267, 31);
            this.name.TabIndex = 11;
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(16, 203);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(198, 31);
            this.tel.TabIndex = 10;
            this.tel.Text = "0";
            this.tel.TextChanged += new System.EventHandler(this.tel_TextChanged);
            // 
            // idno
            // 
            this.idno.Location = new System.Drawing.Point(18, 126);
            this.idno.Name = "idno";
            this.idno.Size = new System.Drawing.Size(198, 31);
            this.idno.TabIndex = 9;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(191, 669);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 32);
            this.save.TabIndex = 8;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(232, 200);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 34);
            this.search.TabIndex = 7;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 503);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Passport";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Area of Residence";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tel No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Information";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(310, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fileToolStripMenuItem.Text = "File ";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Shop,
            this.Total,
            this.vouchers});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(757, 718);
            this.dataGridView1.TabIndex = 0;
            // 
            // shopTableAdapter
            // 
            this.shopTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // shopTableAdapter1
            // 
            this.shopTableAdapter1.ClearBeforeFill = true;
            // 
            // Shop
            // 
            this.Shop.DataSource = this.shopBindingSource1;
            this.Shop.DisplayMember = "name";
            this.Shop.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Shop.HeaderText = "Shop Name";
            this.Shop.Name = "Shop";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total Receipt  Value";
            this.Total.Name = "Total";
            // 
            // vouchers
            // 
            this.vouchers.HeaderText = "Total Vouchers Issued";
            this.vouchers.Name = "vouchers";
            this.vouchers.ReadOnly = true;
            // 
            // entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 718);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "entry";
            this.Text = "DRAW ENTRIES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.entry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawgiftDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private drawgiftDataSet drawgiftDataSet;
        private System.Windows.Forms.BindingSource shopBindingSource;
        private drawgiftDataSetTableAdapters.shopTableAdapter shopTableAdapter;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private drawgiftDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox area;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.TextBox idno;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker datea;
        private System.Windows.Forms.CheckBox checkBox1;
        private Drawgift_Client.shopsDataSet shopsDataSet;
        private System.Windows.Forms.BindingSource shopBindingSource1;
        private Drawgift_Client.shopsDataSetTableAdapters.shopTableAdapter shopTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker birth;
        private System.Windows.Forms.DataGridViewComboBoxColumn Shop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn vouchers;
    }
}