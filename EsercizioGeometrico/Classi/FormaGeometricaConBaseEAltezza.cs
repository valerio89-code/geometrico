using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioGeometrico.Classi
{
    abstract class FormaGeometricaConBaseEAltezza : FormaGeometrica
    {
        protected virtual double Base { get; set; }
        protected virtual double Altezza { get; set; }
        public override void ChiediDimensioni()
        {
            Console.WriteLine("inserisci la base");
            Base = double.Parse(Console.ReadLine());
            Console.WriteLine("inserisci l'altezza");
            Altezza = double.Parse(Console.ReadLine());
        }
    }
}
