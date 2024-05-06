using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IS_SingletonPattern
{
    public class FinanceMenager
    {

        private static FinanceMenager financeMenager;
        private IEnumerable<Transport> Transporti { get; set; }
        private IEnumerable<Vozac> Vozaci { get; set; }
        private Dictionary<int,decimal> Troskovi { get; set; }
        private Dictionary<int,decimal> Dobici { get; set; }


        public FinanceMenager() {
            Troskovi = new Dictionary<int,decimal>();
            Dobici = new Dictionary<int,decimal>();

            Transporti = new List<Transport>()
            {
                new Transport()
                {

            BrojTransporta = 1,
            IdVozaca = 1,
            CarinskiTroskovi = 3500,
            Gorivo = 5000,
            Popravka = 0,
            VrednostRobe = 100000,
            DatumTransporta = new DateOnly(2024, 5, 3)
                }
            };
            Vozaci = new List<Vozac>()
            {
                new Vozac()
                {

            Id = 1,
            Name = "Benjamin",
            Plata = 70000
                }
            };
        }


        //metoda za kreiranje jedinstvenog objekta 
        public static FinanceMenager CreateFinanceMenager()
        {
            //ako nije napravljen jos uvek, vrati ga. U suprotnom, vrati postojeci.
            if (financeMenager == null) 
                financeMenager = new FinanceMenager();
            return financeMenager;
        }
        public decimal MesecniTroskovi(int mesec)
        {
            Troskovi.Clear();
            decimal suma = 0;
            var lista = Transporti.ToList().Where(t => t.DatumTransporta.Month == mesec).ToList();
            foreach (var transport in lista)
            {
                suma += transport.Gorivo + transport.CarinskiTroskovi + transport.Popravka +
                    Vozaci.FirstOrDefault(v => v.Id == transport.IdVozaca).Plata;
            }
            Troskovi.Add(mesec, suma);
            return suma;
        }
        public decimal MesecniDobitak(int mesec)
        {
            Dobici.Clear();
            var lista = Transporti.ToList().Where(t => t.DatumTransporta.Month == mesec).ToList();
            var dobitak =  lista.Sum(l => l.VrednostRobe);
            Dobici.Add(mesec, dobitak);
            return dobitak;

        }

        public void GenerisiIzvestaj(int mesec,decimal trosak, decimal dobitak)
        {
            Izvestaj i = new Izvestaj(mesec,dobitak,trosak);
            Console.WriteLine(i.getIzvestaj());
        }
    }
}
