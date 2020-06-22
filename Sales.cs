using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Tugaslab8
{
    class Sales : Karyawan
    {
        public double jumlahjual { get; set; }
        public double Komisi { get; set; }
        public override double gaji()
        {
            return jumlahjual * Komisi;
        }
    }
}
