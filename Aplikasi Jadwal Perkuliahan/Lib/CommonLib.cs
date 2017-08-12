using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikasi_Jadwal_Perkuliahan.Lib
{
    class CommonLib
    {
        public Dictionary<string, int> GetHari()
        {
            Dictionary<string, int> dictHari = new Dictionary<string, int>();
            dictHari.Add("SENIN", 1);
            dictHari.Add("SELASA", 2);
            dictHari.Add("RABU", 3);
            dictHari.Add("KAMIS", 4);
            dictHari.Add("JUMAT", 5);
            dictHari.Add("SABTU", 6);
            return dictHari;
        }

        public Dictionary<string, string> GetJenisKuliah()
        {
            Dictionary<string, string> dictJenisKuliah = new Dictionary<string, string>();
            dictJenisKuliah.Add("Teori", "T");
            dictJenisKuliah.Add("Praktikum", "P");
            return dictJenisKuliah;
        }
    }
}
