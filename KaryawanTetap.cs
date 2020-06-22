using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Tugaslab8
{
    class KaryawanTetap : Karyawan
    {
        public double Gajiperbulan { get; set; }
        public override double gaji()
        {
            return Gajiperbulan;
        }
    }
}
