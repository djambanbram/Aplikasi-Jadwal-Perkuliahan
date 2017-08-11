using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikasi_Jadwal_Perkuliahan.Model
{
    public class JadwalPerkuliahan
    {
        public int IdKuliah { get; set; }
        public string Ruang { get; set; }
        public string Keterangan { get; set; }
        public int SesiEstimasi { get; set; }
        public int SesiTerjadwal { get; set; }
        public Dosen Dosen { get; set; }
        public Kuliah Kuliah { get; set; }
        public ProgramProdi ProgramProdi { get; set; }
        public Kelas Kelas { get; set; }
        public Hari Hari { get; set; }
        public Jam Jam { get; set; }
    }
    public class Dosen
    {
        public string Nik { get; set; }

        public string NamaDosen { get; set; }
    }

    public class Kuliah
    {
        public string Kode { get; set; }

        public string MataKuliah { get; set; }

        public int Sks { get; set; }

        public int SemesterDitawarkan { get; set; }

        public string SifatMk { get; set; }

        public string JenisMk { get; set; }

        public int SksTeori { get; set; }

        public int SksPraktikum { get; set; }
    }

    public class Kelas
    {
        public int IdKelas { get; set; }

        public string NamaKelas { get; set; }

        public int Angkatan { get; set; }

        public string Semester { get; set; }
    }

    public class Hari
    {
        public int Idhari { get; set; }

        public string NamaHari { get; set; }
    }

    public class Jam
    {
        public int IdJam { get; set; }

        public string NamaJam { get; set; }
    }

    public class SaveJadwalPerkuliahan
    {
        public int IdKuliah { get; set; }
        public string Hari { get; set; }
        public int IdJam { get; set; }
        public string Ruang { get; set; }
        public string Keterangan { get; set; }
    }
}
