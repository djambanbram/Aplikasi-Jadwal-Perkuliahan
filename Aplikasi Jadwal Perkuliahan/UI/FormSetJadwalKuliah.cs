#region Copyright Syncfusion Inc. 2001 - 2016
// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using ApiService;
using Aplikasi_Jadwal_Perkuliahan.Model;
using Aplikasi_Jadwal_Perkuliahan.UIMaster;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Jadwal_Perkuliahan.UI
{
    public partial class FormSetJadwalKuliah : FormUIMaster
    {
        private string URLGetKuliahBelumTerjadwal = WebApi.BaseAddress + "/akademik_api/api/info_jadwal/get_perkuliahan_belum_terjadwal";

        private WebApi webApi;
        private HttpResponseMessage response;

        public FormSetJadwalKuliah()
        {
            InitializeComponent();
            webApi = new WebApi();
        }

        private void Loading(bool isLoading)
        {
            splitContainer1.Enabled = !isLoading;
            flowLayoutPanel2.Enabled = !isLoading;
            progressBar1.Visible = isLoading;
        }

        private async void FormSetJadwalKuliah_Load(object sender, EventArgs e)
        {
            Loading(true);

            var getData = new
            {
                TahunAkademik = LoginAccess.TahunAkademik,
                Semester = LoginAccess.KodeSemester
            };
            var jsonData = JsonConvert.SerializeObject(getData);

            await LoadKuliahBelumTerjadwal(jsonData);
            Loading(false);
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {

        }

        private async Task LoadKuliahBelumTerjadwal(string jsonData)
        {
            response = await webApi.Post(URLGetKuliahBelumTerjadwal, jsonData, true);
            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show(webApi.ReturnMessage(response));
            }

            List<JadwalPerkuliahan> listJadwalPerkuliahan = JsonConvert.DeserializeObject<List<JadwalPerkuliahan>>(response.Content.ReadAsStringAsync().Result);
            if (listJadwalPerkuliahan == null)
            {
                MessageBox.Show("Data mata kuliah gagal di tampilkan");
                return;
            }

            if (listJadwalPerkuliahan.Count == 0)
            {
                MessageBox.Show("Belum ada matakuliah yang sudah dialokasikan");
                return;
            }

            int no = 1;
            foreach (JadwalPerkuliahan jadwal in listJadwalPerkuliahan)
            {
                dgvKuliahBelumTerjadwal.Rows.Add(
                    jadwal.IdKuliah,
                    no,
                    jadwal.Kuliah.Kode,
                    jadwal.Kuliah.MataKuliah,
                    jadwal.Kelas.NamaKelas,
                    jadwal.Dosen.NamaDosen,
                    jadwal.Kuliah.JenisMk,
                    jadwal.Kuliah.SksTeori,
                    jadwal.Kuliah.SksPraktikum);
                no++;
            }
        }
    }
}
