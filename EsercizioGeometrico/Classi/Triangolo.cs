using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioGeometrico.Classi
{
    class Triangolo : FormaGeometricaConBaseEAltezza
    {
        public override string GetArea()
        {
            return $"area triangolo: {Base * Altezza / 2}";
        }
    }
}
