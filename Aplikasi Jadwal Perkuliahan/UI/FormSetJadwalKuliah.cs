#region Copyright Syncfusion Inc. 2001 - 2016
// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using AdvancedDataGridView;
using ApiService;
using Aplikasi_Jadwal_Perkuliahan.Lib;
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
        private string URLGetKuliahSudahTerjadwal = WebApi.BaseAddress + "/akademik_api/api/info_jadwal/get_jadwal_perkuliahan_all";
        private string URLGetRuang = WebApi.BaseAddress + "/akademik_api/api/info_jadwal/get_ruang";
        private string URLGetJamKuliah = WebApi.BaseAddress + "/akademik_api/api/info_jadwal/get_jam_kuliah";

        private WebApi webApi;
        private HttpResponseMessage response;
        private CommonLib commLib;

        private List<JadwalPerkuliahan> listJadwalPerkuliahan;
        private List<JadwalPerkuliahan> listKuliahTerjadwal;
        private List<Ruangan> listRuangTeori;
        private List<Ruangan> listRuangPraktikum;
        private List<JamKuliah> listJamNonSabtu;
        private List<JamKuliah> listJamsabtu;

        public FormSetJadwalKuliah()
        {
            InitializeComponent();
            webApi = new WebApi();
            commLib = new CommonLib();
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
            await LoadJadwalPerkuliahan(jsonData);
            Loading(false);
        }

        private async Task LoadRuangKuliah()
        {
            response = await webApi.Post(URLGetRuang, string.Empty, false);
            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("Gagal menampilkan ruang");
                return;
            }

            listRuangTeori = JsonConvert.DeserializeObject<List<Ruangan>>(response.Content.ReadAsStringAsync().Result)
                                .Where(r => r.IsDipakaiTeori == true).ToList();
            listRuangPraktikum = JsonConvert.DeserializeObject<List<Ruangan>>(response.Content.ReadAsStringAsync().Result)
                                .Where(r => r.IsDipakaiPraktikum == true).ToList();
        }

        private async Task LoadJamKuliah()
        {
            response = await webApi.Post(URLGetJamKuliah, string.Empty, false);
            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("Gagal menampilkan ruang");
                return;
            }

            listJamsabtu = JsonConvert.DeserializeObject<List<JamKuliah>>(response.Content.ReadAsStringAsync().Result)
                                .Where(r => r.IsDipakaiSabtu == true).ToList();
            listJamNonSabtu = JsonConvert.DeserializeObject<List<JamKuliah>>(response.Content.ReadAsStringAsync().Result)
                                .Where(r => r.IsDipakaiSabtu == false).ToList();
        }

        private async Task LoadJadwalPerkuliahan(string jsonData)
        {
            await LoadRuangKuliah();
            await LoadJamKuliah();

            //Add Nodes hari, ruang
            int Nodes1 = 0;
            TreeGridNode tgn1 = null;
            TreeGridNode tgn2 = null;
            foreach (string hari in commLib.GetHari().Keys)
            {
                var nodes = dgvKuliahTerjadwal.Nodes;
                nodes.Add(null, hari);
                foreach (string jenisKuliah in commLib.GetJenisKuliah().Keys)
                {
                    tgn1 = dgvKuliahTerjadwal.Nodes[Nodes1];
                    tgn1.DefaultCellStyle.BackColor = Color.LightGray;
                    if (hari == "SABTU")
                    {
                        tgn1.Nodes.Add(null, jenisKuliah,
                            string.Format("{0} - {1}", listJamsabtu[0].JamMulai, listJamsabtu[0].JamSelesai),
                            string.Format("{0} - {1}", listJamsabtu[1].JamMulai, listJamsabtu[1].JamSelesai),
                            string.Format("{0} - {1}", listJamsabtu[2].JamMulai, listJamsabtu[2].JamSelesai),
                            string.Format("{0} - {1}", listJamsabtu[3].JamMulai, listJamsabtu[3].JamSelesai),
                            string.Format("{0} - {1}", listJamsabtu[4].JamMulai, listJamsabtu[4].JamSelesai));
                    }
                    else
                    {

                        tgn1.Nodes.Add(null, jenisKuliah,
                            string.Format("{0} - {1}", listJamNonSabtu[0].JamMulai, listJamNonSabtu[0].JamSelesai),
                            string.Format("{0} - {1}", listJamNonSabtu[1].JamMulai, listJamNonSabtu[1].JamSelesai),
                            string.Format("{0} - {1}", listJamNonSabtu[2].JamMulai, listJamNonSabtu[2].JamSelesai),
                            string.Format("{0} - {1}", listJamNonSabtu[3].JamMulai, listJamNonSabtu[3].JamSelesai),
                            string.Format("{0} - {1}", listJamNonSabtu[4].JamMulai, listJamNonSabtu[4].JamSelesai));
                    }
                    
                    if (commLib.GetJenisKuliah()[jenisKuliah] == "T")
                    {
                        tgn2 = dgvKuliahTerjadwal.Nodes[Nodes1].Nodes[0];
                        foreach (Ruangan ruang in listRuangTeori)
                        {
                            tgn2.Nodes.Add(null, ruang.Ruang);
                            tgn2.DefaultCellStyle.BackColor = Color.LightGray;
                        }
                        tgn1.Expand();
                        tgn2.Expand();
                    }
                    else if (commLib.GetJenisKuliah()[jenisKuliah] == "P")
                    {
                        tgn2 = dgvKuliahTerjadwal.Nodes[Nodes1].Nodes[1];
                        foreach (Ruangan ruang in listRuangPraktikum)
                        {
                            tgn2.Nodes.Add(null, ruang.Ruang);
                            tgn2.DefaultCellStyle.BackColor = Color.LightGray;
                        }
                        tgn1.Expand();
                        tgn2.Expand();
                    }
                }
                Nodes1++;
            }
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            int no = 1;
            dgvKuliahBelumTerjadwal.Rows.Clear();
            foreach (JadwalPerkuliahan jadwal in listJadwalPerkuliahan.Where(j =>
                                                j.Dosen.Nik.ToLower().Contains(txtCari.Text.ToLower()) ||
                                                j.Dosen.NamaDosen.ToLower().Contains(txtCari.Text.ToLower()) ||
                                                j.Kuliah.MataKuliah.ToLower().Contains(txtCari.Text.ToLower()) ||
                                                j.Kuliah.Kode.ToLower().Contains(txtCari.Text.ToLower()) ||
                                                j.Kelas.NamaKelas.ToLower().Contains(txtCari.Text.ToLower()))
                                                .Where(j => j.SesiTerjadwal < j.SesiEstimasi).ToList())
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
                    jadwal.Kuliah.SksPraktikum,
                    jadwal.SesiEstimasi,
                    jadwal.SesiTerjadwal);
                no++;
            }
            dgvKuliahBelumTerjadwal.PerformLayout();
        }

        private async Task LoadKuliahBelumTerjadwal(string jsonData)
        {
            response = await webApi.Post(URLGetKuliahBelumTerjadwal, jsonData, true);
            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show(webApi.ReturnMessage(response));
            }

            listJadwalPerkuliahan = JsonConvert.DeserializeObject<List<JadwalPerkuliahan>>(response.Content.ReadAsStringAsync().Result);

            List<JadwalPerkuliahan> tempList = listJadwalPerkuliahan.Where(j => j.SesiTerjadwal < j.SesiEstimasi).ToList();
            dgvKuliahBelumTerjadwal.Rows.Clear();
            int no = 1;
            foreach (JadwalPerkuliahan jadwal in tempList)
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
                    jadwal.Kuliah.SksPraktikum,
                    jadwal.SesiEstimasi,
                    jadwal.SesiTerjadwal);
                no++;
            }
            dgvKuliahBelumTerjadwal.PerformLayout();
        }

        private async Task LoadKuliahTerjadwal(string jsonData)
        {
            response = await webApi.Post(URLGetKuliahSudahTerjadwal, jsonData, false);
            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show(webApi.ReturnMessage(response));
            }

            listKuliahTerjadwal = JsonConvert.DeserializeObject<List<JadwalPerkuliahan>>(response.Content.ReadAsStringAsync().Result);
            MessageBox.Show(listKuliahTerjadwal.Count.ToString());
        }
    }
}
