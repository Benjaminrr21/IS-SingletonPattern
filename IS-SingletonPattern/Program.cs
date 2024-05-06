using IS_SingletonPattern;

using System;

class Program
{
    static void Main(string[] args)
    {
        
       

        //PROVERA

        FinanceMenager financeManager1 = FinanceMenager.CreateFinanceMenager();
        FinanceMenager financeManager2 = FinanceMenager.CreateFinanceMenager();

        // Proverimo da li su instance isti objekat
        if (ReferenceEquals(financeManager1, financeManager2))
        {

            Console.WriteLine("Menadzer finansija informacionog sistema za spedicije - OkSped.");
            //Console.ReadLine();
            //Console.WriteLine("Singleton pattern je ispravno implementiran.");
        }
        else
        {
            Console.WriteLine("Singleton pattern nije ispravno implementiran.");
            //Console.ReadLine();
        }

        decimal trosak = financeManager1.MesecniTroskovi(5);
        decimal dobit = financeManager1.MesecniDobitak(5);
        financeManager1.GenerisiIzvestaj(5,trosak,dobit);
        
    }
}
