#region Copyright Syncfusion Inc. 2001 - 2016
// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Aplikasi_Jadwal_Perkuliahan.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplikasi_Jadwal_Perkuliahan
{
    public partial class FormMainAplikasi : Syncfusion.Windows.Forms.MetroForm
    {
        private FormSetJadwalKuliah formSetJadwalKuliah;

        public FormMainAplikasi()
        {
            InitializeComponent();
        }

        private void itemClick(object sender, Syncfusion.Windows.Forms.Tools.XPTaskBarItemClickArgs e)
        {
            Form form = null;

            if (e.XPTaskBarItem.Name == "itemSetJadwal")
            {
                if (formSetJadwalKuliah == null || formSetJadwalKuliah.IsDisposed)
                {
                    formSetJadwalKuliah = new FormSetJadwalKuliah();
                    formSetJadwalKuliah.MdiParent = this;
                }
                form = formSetJadwalKuliah;
            }

            if (form != null && !form.IsDisposed)
            {
                form.Show();
                tabbedMDIManager1.UpdateActiveTabHost(form);
            }
        }

        private void FormMainAplikasi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
