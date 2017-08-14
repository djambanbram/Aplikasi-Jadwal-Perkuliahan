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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvKuliahBelumTerjadwal = new System.Windows.Forms.DataGridView();
            this.IdKuliah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MataKuliah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dosen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JenisKuliah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SksT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SksP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SesiEstimasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SesiTerjadwal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtCari = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.panel1 = new System.Windows.Forms.Panel();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvKuliahTerjadwal = new AdvancedDataGridView.TreeGridView();
            this.tree = new AdvancedDataGridView.TreeGridColumn();
            this.Hari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jam1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jam2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jam3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jam4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jam5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKuliahBelumTerjadwal)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCari)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKuliahTerjadwal)).BeginInit();
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
            this.splitContainer1.Size = new System.Drawing.Size(935, 427);
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
            this.groupBox1.Size = new System.Drawing.Size(935, 202);
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
            this.dgvKuliahBelumTerjadwal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvKuliahBelumTerjadwal.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKuliahBelumTerjadwal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKuliahBelumTerjadwal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKuliahBelumTerjadwal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdKuliah,
            this.No,
            this.Kode,
            this.MataKuliah,
            this.Kelas,
            this.Nik,
            this.Dosen,
            this.JenisKuliah,
            this.SksT,
            this.SksP,
            this.SesiEstimasi,
            this.SesiTerjadwal});
            this.dgvKuliahBelumTerjadwal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKuliahBelumTerjadwal.Location = new System.Drawing.Point(3, 54);
            this.dgvKuliahBelumTerjadwal.MultiSelect = false;
            this.dgvKuliahBelumTerjadwal.Name = "dgvKuliahBelumTerjadwal";
            this.dgvKuliahBelumTerjadwal.ReadOnly = true;
            this.dgvKuliahBelumTerjadwal.RowHeadersVisible = false;
            this.dgvKuliahBelumTerjadwal.RowHeadersWidth = 30;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvKuliahBelumTerjadwal.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvKuliahBelumTerjadwal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKuliahBelumTerjadwal.Size = new System.Drawing.Size(929, 145);
            this.dgvKuliahBelumTerjadwal.TabIndex = 1;
            this.dgvKuliahBelumTerjadwal.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvKuliahBelumTerjadwal_DragDrop);
            this.dgvKuliahBelumTerjadwal.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvKuliahBelumTerjadwal_DragEnter);
            this.dgvKuliahBelumTerjadwal.DragOver += new System.Windows.Forms.DragEventHandler(this.dgvKuliahBelumTerjadwal_DragOver);
            this.dgvKuliahBelumTerjadwal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvKuliahBelumTerjadwal_MouseDown);
            this.dgvKuliahBelumTerjadwal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvKuliahBelumTerjadwal_MouseMove);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.No.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.Kode.Width = 50;
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
            this.Kelas.Width = 160;
            // 
            // Nik
            // 
            this.Nik.HeaderText = "NIK";
            this.Nik.Name = "Nik";
            this.Nik.ReadOnly = true;
            this.Nik.Visible = false;
            // 
            // Dosen
            // 
            this.Dosen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dosen.HeaderText = "Dosen";
            this.Dosen.Name = "Dosen";
            this.Dosen.ReadOnly = true;
            // 
            // JenisKuliah
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.JenisKuliah.DefaultCellStyle = dataGridViewCellStyle3;
            this.JenisKuliah.HeaderText = "Jenis Kuliah";
            this.JenisKuliah.Name = "JenisKuliah";
            this.JenisKuliah.ReadOnly = true;
            this.JenisKuliah.Width = 50;
            // 
            // SksT
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SksT.DefaultCellStyle = dataGridViewCellStyle4;
            this.SksT.HeaderText = "Sks T";
            this.SksT.Name = "SksT";
            this.SksT.ReadOnly = true;
            this.SksT.Width = 40;
            // 
            // SksP
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SksP.DefaultCellStyle = dataGridViewCellStyle5;
            this.SksP.HeaderText = "Sks P";
            this.SksP.Name = "SksP";
            this.SksP.ReadOnly = true;
            this.SksP.Width = 40;
            // 
            // SesiEstimasi
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SesiEstimasi.DefaultCellStyle = dataGridViewCellStyle6;
            this.SesiEstimasi.HeaderText = "Sesi Estimasi";
            this.SesiEstimasi.Name = "SesiEstimasi";
            this.SesiEstimasi.ReadOnly = true;
            this.SesiEstimasi.Width = 60;
            // 
            // SesiTerjadwal
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SesiTerjadwal.DefaultCellStyle = dataGridViewCellStyle7;
            this.SesiTerjadwal.HeaderText = "Sesi Terjadwal";
            this.SesiTerjadwal.Name = "SesiTerjadwal";
            this.SesiTerjadwal.ReadOnly = true;
            this.SesiTerjadwal.Width = 70;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.autoLabel1);
            this.flowLayoutPanel2.Controls.Add(this.txtCari);
            this.flowLayoutPanel2.Controls.Add(this.panel1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 21);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(929, 33);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.autoLabel3);
            this.panel1.Controls.Add(this.autoLabel2);
            this.panel1.Location = new System.Drawing.Point(345, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 25);
            this.panel1.TabIndex = 2;
            // 
            // autoLabel3
            // 
            this.autoLabel3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel3.ForeColor = System.Drawing.Color.Red;
            this.autoLabel3.Location = new System.Drawing.Point(0, 12);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(370, 13);
            this.autoLabel3.TabIndex = 1;
            this.autoLabel3.Text = "*Sesi Terjadwal: Jumlah pertemuan per minggu yang telah dijadwalkan";
            // 
            // autoLabel2
            // 
            this.autoLabel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel2.ForeColor = System.Drawing.Color.Red;
            this.autoLabel2.Location = new System.Drawing.Point(0, -2);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(553, 13);
            this.autoLabel2.TabIndex = 0;
            this.autoLabel2.Text = "*Sesi Estimasi: Estimasi pertemuan per minggu berdasarkan jumlah SKS (lebih dari " +
    "3 SKS 2 sesi per minggu)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvKuliahTerjadwal);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(935, 221);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kuliah sudah terjadwal";
            // 
            // dgvKuliahTerjadwal
            // 
            this.dgvKuliahTerjadwal.AllowDrop = true;
            this.dgvKuliahTerjadwal.AllowUserToAddRows = false;
            this.dgvKuliahTerjadwal.AllowUserToDeleteRows = false;
            this.dgvKuliahTerjadwal.AllowUserToResizeRows = false;
            this.dgvKuliahTerjadwal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvKuliahTerjadwal.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvKuliahTerjadwal.ColumnHeadersHeight = 27;
            this.dgvKuliahTerjadwal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvKuliahTerjadwal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tree,
            this.Hari,
            this.Jam1,
            this.Jam2,
            this.Jam3,
            this.Jam4,
            this.Jam5});
            this.dgvKuliahTerjadwal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKuliahTerjadwal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvKuliahTerjadwal.ImageList = null;
            this.dgvKuliahTerjadwal.Location = new System.Drawing.Point(3, 21);
            this.dgvKuliahTerjadwal.MultiSelect = false;
            this.dgvKuliahTerjadwal.Name = "dgvKuliahTerjadwal";
            this.dgvKuliahTerjadwal.ReadOnly = true;
            this.dgvKuliahTerjadwal.RowHeadersVisible = false;
            this.dgvKuliahTerjadwal.RowHeadersWidth = 30;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvKuliahTerjadwal.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvKuliahTerjadwal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvKuliahTerjadwal.Size = new System.Drawing.Size(929, 197);
            this.dgvKuliahTerjadwal.TabIndex = 0;
            this.dgvKuliahTerjadwal.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvKuliahTerjadwal_DragDrop);
            this.dgvKuliahTerjadwal.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvKuliahTerjadwal_DragEnter);
            this.dgvKuliahTerjadwal.DragOver += new System.Windows.Forms.DragEventHandler(this.dgvKuliahTerjadwal_DragOver);
            this.dgvKuliahTerjadwal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvKuliahTerjadwal_MouseDown);
            this.dgvKuliahTerjadwal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvKuliahTerjadwal_MouseMove);
            // 
            // tree
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightGray;
            this.tree.DefaultCellStyle = dataGridViewCellStyle9;
            this.tree.DefaultNodeImage = null;
            this.tree.Frozen = true;
            this.tree.HeaderText = "";
            this.tree.Name = "tree";
            this.tree.ReadOnly = true;
            this.tree.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tree.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tree.Width = 40;
            // 
            // Hari
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightGray;
            this.Hari.DefaultCellStyle = dataGridViewCellStyle10;
            this.Hari.Frozen = true;
            this.Hari.HeaderText = "Hari";
            this.Hari.Name = "Hari";
            this.Hari.ReadOnly = true;
            this.Hari.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Hari.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Jam1
            // 
            this.Jam1.HeaderText = "Jam Ke-1";
            this.Jam1.Name = "Jam1";
            this.Jam1.ReadOnly = true;
            this.Jam1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Jam1.Width = 400;
            // 
            // Jam2
            // 
            this.Jam2.HeaderText = "Jam Ke-2";
            this.Jam2.Name = "Jam2";
            this.Jam2.ReadOnly = true;
            this.Jam2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Jam2.Width = 400;
            // 
            // Jam3
            // 
            this.Jam3.HeaderText = "jam Ke-3";
            this.Jam3.Name = "Jam3";
            this.Jam3.ReadOnly = true;
            this.Jam3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Jam3.Width = 400;
            // 
            // Jam4
            // 
            this.Jam4.HeaderText = "Jam Ke-4";
            this.Jam4.Name = "Jam4";
            this.Jam4.ReadOnly = true;
            this.Jam4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Jam4.Width = 400;
            // 
            // Jam5
            // 
            this.Jam5.HeaderText = "Jam Ke-5";
            this.Jam5.Name = "Jam5";
            this.Jam5.ReadOnly = true;
            this.Jam5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Jam5.Width = 400;
            // 
            // FormSetJadwalKuliah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 463);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKuliahTerjadwal)).EndInit();
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
        private AdvancedDataGridView.TreeGridView dgvKuliahTerjadwal;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdKuliah;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kode;
        private System.Windows.Forms.DataGridViewTextBoxColumn MataKuliah;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosen;
        private System.Windows.Forms.DataGridViewTextBoxColumn JenisKuliah;
        private System.Windows.Forms.DataGridViewTextBoxColumn SksT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SksP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SesiEstimasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SesiTerjadwal;
        private AdvancedDataGridView.TreeGridColumn tree;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hari;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jam1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jam2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jam3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jam4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jam5;
    }
}