using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioGeometrico.Classi
{
    abstract class FormaGeometrica
    {
        public string Colore { get; set; }
        public abstract string GetArea();
        public abstract void ChiediDimensioni();
        public virtual string GetPianoCartesiano()
        {
            return "xy";
        }

        public static FormaGeometrica GetFigura(string tipoFigura)
        {
            switch (tipoFigura)
            {
                case "cerchio":
                    return new Cerchio();
                case "triangolo":
                    return new Triangolo();
                case "rettangolo":
                    return new Rettangolo();
                case "quadrato":
                    return new Quadrato();
                default:
                    return null;
            }
        }
    }
}
