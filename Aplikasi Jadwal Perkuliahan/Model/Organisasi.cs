using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikasi_Jadwal_Perkuliahan.Model
{
    public class Fakultas
    {
        public string KodeFakultas { get; set; }

        public string Namafakultas { get; set; }
    }

    public class ProgramStudi
    {
        public Guid Id { get; set; }

        public string IdProdi { get; set; }

        public string NamaProdi { get; set; }

        public string Jenjang { get; set; }

        public Fakultas Fakultas { get; set; }
    }

    public class ProgramProdi
    {
        public string KodeProgram { get; set; }

        public string NamaProgram { get; set; }

        public ProgramStudi ProgramStudi { get; set; }
    }
}
