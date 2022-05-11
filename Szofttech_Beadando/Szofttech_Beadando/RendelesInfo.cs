using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szofttech_Beadando
{
    class RendelesInfo
    {
        public int id { get; set; }
        public string konyvCim { get; set; }
        public int? konyvAr { get; set; }
        public double? kedvezmenyesAr { get; set; }

        public int kedvezmeny { get; set; }
    }
}
