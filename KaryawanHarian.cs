using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Tugaslab8
{
    class KaryawanHarian : Karyawan
    {
        public double gajiperjam { get; set; }
        public double jamkerja { get; set; }
        public override double gaji()
        {
            return gajiperjam * jamkerja;
        }
    }
}
