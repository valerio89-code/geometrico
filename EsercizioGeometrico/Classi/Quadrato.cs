using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioGeometrico.Classi
{
    class Quadrato : Rettangolo
    {
        protected double Lato { get; set; }
        public override string GetArea()
        {
            return $"area quadrato: {Math.Pow(Lato, 2)}";
        }
        public override void ChiediDimensioni()
        {
            Console.WriteLine("Inserisci il lato del quadrato");
            Lato = double.Parse(Console.ReadLine());
        }
    }
}
