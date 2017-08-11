#region Copyright Syncfusion Inc. 2001 - 2016
// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace Aplikasi_Jadwal_Perkuliahan
{
    partial class FormMainAplikasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainAplikasi));
            this.tabbedMDIManager1 = new Syncfusion.Windows.Forms.Tools.TabbedMDIManager(this.components);
            this.Penjadwalan = new Syncfusion.Windows.Forms.Tools.XPTaskBar();
            this.xpTaskBarBox1 = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.xpTaskBarBox2 = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.xpTaskBarBox3 = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            ((System.ComponentModel.ISupportInitialize)(this.Penjadwalan)).BeginInit();
            this.Penjadwalan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBarBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBarBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBarBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabbedMDIManager1
            // 
            this.tabbedMDIManager1.AttachedTo = this;
            this.tabbedMDIManager1.CloseButtonBackColor = System.Drawing.Color.White;
            this.tabbedMDIManager1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabbedMDIManager1.NeedUpdateHostedForm = false;
            // 
            // Penjadwalan
            // 
            this.Penjadwalan.BackColor = System.Drawing.Color.White;
            this.Penjadwalan.BeforeTouchSize = new System.Drawing.Size(244, 479);
            this.Penjadwalan.BorderColor = System.Drawing.Color.Black;
            this.Penjadwalan.Controls.Add(this.xpTaskBarBox1);
            this.Penjadwalan.Controls.Add(this.xpTaskBarBox2);
            this.Penjadwalan.Controls.Add(this.xpTaskBarBox3);
            this.Penjadwalan.Dock = System.Windows.Forms.DockStyle.Left;
            this.Penjadwalan.Location = new System.Drawing.Point(0, 0);
            this.Penjadwalan.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.Penjadwalan.MinimumSize = new System.Drawing.Size(0, 0);
            this.Penjadwalan.Name = "Penjadwalan";
            this.Penjadwalan.Size = new System.Drawing.Size(244, 479);
            this.Penjadwalan.TabIndex = 0;
            // 
            // xpTaskBarBox1
            // 
            this.xpTaskBarBox1.HeaderBackColor = System.Drawing.Color.CornflowerBlue;
            this.xpTaskBarBox1.HeaderImageIndex = -1;
            this.xpTaskBarBox1.HitTaskBoxArea = false;
            this.xpTaskBarBox1.HotTrackColor = System.Drawing.Color.Empty;
            this.xpTaskBarBox1.ItemBackColor = System.Drawing.Color.White;
            this.xpTaskBarBox1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPTaskBarItem[] {
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Set Jadwal Kuliah", System.Drawing.Color.Empty, -1, null, "", true, true, "itemSetJadwal", new System.Drawing.Font("Segoe UI", 9.75F), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Set Jadwal Tanpa Validasi", System.Drawing.Color.Empty, -1, null, "", true, true, "itemSetJadwalTanpaValidasi", new System.Drawing.Font("Segoe UI", 9.75F), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Pindah Jadwal", System.Drawing.Color.Empty, -1, null, "", true, true, "itemPindahJadwal", new System.Drawing.Font("Segoe UI", 9.75F), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Ruang Kosong", System.Drawing.Color.Empty, -1, null, "", true, true, "itemRuangKosong", new System.Drawing.Font("Segoe UI", 9.75F), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Hapus Jadwal Double", System.Drawing.Color.Empty, -1, null, "", true, true, "itemHapusJadwalDouble", new System.Drawing.Font("Segoe UI", 9.75F), 0)});
            this.xpTaskBarBox1.Location = new System.Drawing.Point(0, 0);
            this.xpTaskBarBox1.Name = "xpTaskBarBox1";
            this.xpTaskBarBox1.Size = new System.Drawing.Size(244, 154);
            this.xpTaskBarBox1.TabIndex = 0;
            this.xpTaskBarBox1.Text = "Penjadwalan";
            this.xpTaskBarBox1.ItemClick += new Syncfusion.Windows.Forms.Tools.XPTaskBarItemClickHandler(this.itemClick);
            // 
            // xpTaskBarBox2
            // 
            this.xpTaskBarBox2.HeaderBackColor = System.Drawing.Color.CornflowerBlue;
            this.xpTaskBarBox2.HeaderImageIndex = -1;
            this.xpTaskBarBox2.HitTaskBoxArea = false;
            this.xpTaskBarBox2.HotTrackColor = System.Drawing.Color.Empty;
            this.xpTaskBarBox2.ItemBackColor = System.Drawing.Color.White;
            this.xpTaskBarBox2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPTaskBarItem[] {
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Laporan Jadwal Kuliah", System.Drawing.Color.Empty, -1, null, "", true, true, "itemLaporan", new System.Drawing.Font("Segoe UI", 9.75F), 0)});
            this.xpTaskBarBox2.Location = new System.Drawing.Point(0, 154);
            this.xpTaskBarBox2.Name = "xpTaskBarBox2";
            this.xpTaskBarBox2.Size = new System.Drawing.Size(244, 58);
            this.xpTaskBarBox2.TabIndex = 1;
            this.xpTaskBarBox2.Text = "Laporan";
            // 
            // xpTaskBarBox3
            // 
            this.xpTaskBarBox3.HeaderBackColor = System.Drawing.Color.CornflowerBlue;
            this.xpTaskBarBox3.HeaderImageIndex = -1;
            this.xpTaskBarBox3.HitTaskBoxArea = false;
            this.xpTaskBarBox3.HotTrackColor = System.Drawing.Color.Empty;
            this.xpTaskBarBox3.ItemBackColor = System.Drawing.Color.White;
            this.xpTaskBarBox3.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPTaskBarItem[] {
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Keluar", System.Drawing.Color.Empty, -1, null, "", true, true, "itemKeluar", new System.Drawing.Font("Segoe UI", 9.75F), 0)});
            this.xpTaskBarBox3.Location = new System.Drawing.Point(0, 212);
            this.xpTaskBarBox3.Name = "xpTaskBarBox3";
            this.xpTaskBarBox3.Size = new System.Drawing.Size(244, 58);
            this.xpTaskBarBox3.TabIndex = 2;
            this.xpTaskBarBox3.Text = "Keluar";
            // 
            // FormMainAplikasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(859, 479);
            this.Controls.Add(this.Penjadwalan);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMainAplikasi";
            this.Text = "Aplikasi Penjadwalan Perkuliahan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMainAplikasi_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Penjadwalan)).EndInit();
            this.Penjadwalan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBarBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBarBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBarBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.TabbedMDIManager tabbedMDIManager1;
        private Syncfusion.Windows.Forms.Tools.XPTaskBar Penjadwalan;
        private Syncfusion.Windows.Forms.Tools.XPTaskBarBox xpTaskBarBox1;
        private Syncfusion.Windows.Forms.Tools.XPTaskBarBox xpTaskBarBox2;
        private Syncfusion.Windows.Forms.Tools.XPTaskBarBox xpTaskBarBox3;
    }
}