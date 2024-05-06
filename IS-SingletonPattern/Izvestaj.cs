using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_SingletonPattern
{
    public class Izvestaj
    {
        public decimal Prihod {  get; set; }
        public decimal Rashod { get; set; }
        public int Mesec { get; }

        public Izvestaj(int mesec,decimal pihod, decimal rashod)
        {
            Mesec = mesec;
            Prihod = pihod;
            Rashod = rashod;
        }

        public string getIzvestaj()
        {

            return $"Izvestaj za mesec: {Mesec} \n Prihodi: {Prihod} \n Rashodi {Rashod} \n Konacna zarada: {Prihod - Rashod} \n";
        }
    }
}
