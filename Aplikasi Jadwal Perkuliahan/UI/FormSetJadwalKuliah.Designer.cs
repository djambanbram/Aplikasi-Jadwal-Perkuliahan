#region Copyright Syncfusion Inc. 2001 - 2016
// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace Aplikasi_Jadwal_Perkuliahan.UI
{
    partial class FormSetJadwalKuliah
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvKuliahBelumTerjadwal = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtCari = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.treeGridView1 = new AdvancedDataGridView.TreeGridView();
            this.IdKuliah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MataKuliah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dosen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JenisKuliah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SksT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SksP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKuliahBelumTerjadwal)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCari)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(816, 427);
            this.splitContainer1.SplitterDistance = 202;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKuliahBelumTerjadwal);
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kuliah belum terjadwal";
            // 
            // dgvKuliahBelumTerjadwal
            // 
            this.dgvKuliahBelumTerjadwal.AllowDrop = true;
            this.dgvKuliahBelumTerjadwal.AllowUserToAddRows = false;
            this.dgvKuliahBelumTerjadwal.AllowUserToDeleteRows = false;
            this.dgvKuliahBelumTerjadwal.AllowUserToResizeColumns = false;
            this.dgvKuliahBelumTerjadwal.AllowUserToResizeRows = false;
            this.dgvKuliahBelumTerjadwal.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvKuliahBelumTerjadwal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKuliahBelumTerjadwal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdKuliah,
            this.No,
            this.Kode,
            this.MataKuliah,
            this.Kelas,
            this.Dosen,
            this.JenisKuliah,
            this.SksT,
            this.SksP});
            this.dgvKuliahBelumTerjadwal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKuliahBelumTerjadwal.Location = new System.Drawing.Point(3, 54);
            this.dgvKuliahBelumTerjadwal.MultiSelect = false;
            this.dgvKuliahBelumTerjadwal.Name = "dgvKuliahBelumTerjadwal";
            this.dgvKuliahBelumTerjadwal.ReadOnly = true;
            this.dgvKuliahBelumTerjadwal.RowHeadersVisible = false;
            this.dgvKuliahBelumTerjadwal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKuliahBelumTerjadwal.Size = new System.Drawing.Size(810, 145);
            this.dgvKuliahBelumTerjadwal.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.autoLabel1);
            this.flowLayoutPanel2.Controls.Add(this.txtCari);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 21);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(810, 33);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // autoLabel1
            // 
            this.autoLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autoLabel1.Location = new System.Drawing.Point(3, 0);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(31, 31);
            this.autoLabel1.TabIndex = 0;
            this.autoLabel1.Text = "Cari";
            this.autoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCari
            // 
            this.txtCari.BeforeTouchSize = new System.Drawing.Size(299, 25);
            this.txtCari.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCari.Location = new System.Drawing.Point(40, 3);
            this.txtCari.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(299, 25);
            this.txtCari.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCari.TabIndex = 1;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.treeGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(816, 221);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kuliah sudah terjadwal";
            // 
            // treeGridView1
            // 
            this.treeGridView1.AllowUserToAddRows = false;
            this.treeGridView1.AllowUserToDeleteRows = false;
            this.treeGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.treeGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.treeGridView1.ImageList = null;
            this.treeGridView1.Location = new System.Drawing.Point(3, 21);
            this.treeGridView1.Name = "treeGridView1";
            this.treeGridView1.Size = new System.Drawing.Size(810, 197);
            this.treeGridView1.TabIndex = 0;
            // 
            // IdKuliah
            // 
            this.IdKuliah.HeaderText = "IdKuliah";
            this.IdKuliah.Name = "IdKuliah";
            this.IdKuliah.ReadOnly = true;
            this.IdKuliah.Visible = false;
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.No.DefaultCellStyle = dataGridViewCellStyle1;
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 51;
            // 
            // Kode
            // 
            this.Kode.HeaderText = "Kode";
            this.Kode.Name = "Kode";
            this.Kode.ReadOnly = true;
            this.Kode.Width = 60;
            // 
            // MataKuliah
            // 
            this.MataKuliah.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MataKuliah.HeaderText = "Mata Kuliah";
            this.MataKuliah.Name = "MataKuliah";
            this.MataKuliah.ReadOnly = true;
            // 
            // Kelas
            // 
            this.Kelas.HeaderText = "Kelas";
            this.Kelas.Name = "Kelas";
            this.Kelas.ReadOnly = true;
            // 
            // Dosen
            // 
            this.Dosen.HeaderText = "Dosen";
            this.Dosen.Name = "Dosen";
            this.Dosen.ReadOnly = true;
            this.Dosen.Width = 230;
            // 
            // JenisKuliah
            // 
            this.JenisKuliah.HeaderText = "Jenis Kuliah";
            this.JenisKuliah.Name = "JenisKuliah";
            this.JenisKuliah.ReadOnly = true;
            this.JenisKuliah.Width = 50;
            // 
            // SksT
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SksT.DefaultCellStyle = dataGridViewCellStyle2;
            this.SksT.HeaderText = "Sks T";
            this.SksT.Name = "SksT";
            this.SksT.ReadOnly = true;
            this.SksT.Width = 50;
            // 
            // SksP
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SksP.DefaultCellStyle = dataGridViewCellStyle3;
            this.SksP.HeaderText = "Sks P";
            this.SksP.Name = "SksP";
            this.SksP.ReadOnly = true;
            this.SksP.Width = 50;
            // 
            // FormSetJadwalKuliah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 463);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormSetJadwalKuliah";
            this.Text = "Set Jadwal Perkuliahan";
            this.Load += new System.EventHandler(this.FormSetJadwalKuliah_Load);
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKuliahBelumTerjadwal)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCari)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCari;
        private System.Windows.Forms.DataGridView dgvKuliahBelumTerjadwal;
        private AdvancedDataGridView.TreeGridView treeGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdKuliah;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kode;
        private System.Windows.Forms.DataGridViewTextBoxColumn MataKuliah;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosen;
        private System.Windows.Forms.DataGridViewTextBoxColumn JenisKuliah;
        private System.Windows.Forms.DataGridViewTextBoxColumn SksT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SksP;
    }
}