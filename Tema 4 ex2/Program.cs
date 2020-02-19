using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_4_ex2
{
    //Exercitiul 2
    public class Imobil
    {
       
        public string tipCasa{ get; set; }
        public int nrEtaje { get; set; }
        public double pret { get; set; }

        

        public Imobil()
        {
            tipCasa = "";
            nrEtaje = 0;
            pret = 0.0;
        }
        public Imobil(string tipCasa)
        {
            this.tipCasa = tipCasa;
            this.nrEtaje = 0;
            this.pret = 0.0;
        }
        public Imobil(string tip, int nrEtaje, double pret)
        {
            tipCasa = tip;
            this.nrEtaje = nrEtaje;
            this.pret = pret;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Imobil imb = new Imobil();
            
            //imb.afiseazaDetalii();
            imb.tipCasa = "apartament";
            imb.nrEtaje = 1;
            imb.pret = 130000.50;

            Console.WriteLine();
            Console.WriteLine("tipCasa: " + imb.tipCasa + "\nnrEtaje: " + imb.nrEtaje + "\npret: " + imb.pret);

            Imobil imb1 = new Imobil("casa");
            imb1.nrEtaje = 2;
            imb1.pret = 95000.99;

            Console.WriteLine();
            Console.WriteLine("tipCasa: " + imb1.tipCasa + "\nnrEtaje: " + imb1.nrEtaje + "\npret: " + imb1.pret);

            Imobil imb2 = new Imobil("Vila", 4, 150000.1);

            Console.WriteLine();
            Console.WriteLine("tipCasa: " + imb2.tipCasa + "\nnrEtaje: " + imb2.nrEtaje + "\npret: " + imb2.pret);

            Console.ReadLine();


        }
    }
}
