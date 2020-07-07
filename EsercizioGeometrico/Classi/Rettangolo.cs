using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioGeometrico.Classi
{
    class Rettangolo : FormaGeometricaConBaseEAltezza
    {
        public override string GetArea()
        {
            return $"area rettangolo: {Base * Altezza}";
        }
    }
}
