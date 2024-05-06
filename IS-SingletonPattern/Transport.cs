using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_SingletonPattern
{
    public class Transport
    {
        public int BrojTransporta {  get; set; }
        public DateOnly DatumTransporta { get; set; }
        public decimal Gorivo { get; set; }
        public decimal Popravka { get; set; }
        public decimal VrednostRobe { get; set; }
        public int IdVozaca { get; set; }
        public decimal CarinskiTroskovi { get; set; }

    }
}
