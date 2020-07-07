using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioGeometrico.Classi
{
    class Cerchio : FormaGeometrica
    {
        protected double Raggio { get; set; }

        public override void ChiediDimensioni()
        {
            Console.WriteLine("Inserisci la dimensione del raggio");
            Raggio = double.Parse(Console.ReadLine());
        }

        public override string GetArea()
        {
            return $"area cerchio: {Math.Pow(Raggio,2) * Math.PI}";
        }
    }
}
