using EsercizioGeometrico.Classi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioGeometrico
{
    class Program
    {
        //che tipo di figura vuoi vedere?
        //chiede le dimensioni della figura scelta
        //cosa vuoi fare?
        //1 calcola area
        //2 calcola perimetro
        //3 disegna figura
        static void Main(string[] args)
        {
            Console.WriteLine("Che figura vuoi vedere?");
            var tipoFigura = Console.ReadLine();
            FormaGeometrica figura = FormaGeometrica.GetFigura(tipoFigura);
            figura.ChiediDimensioni();
            Console.WriteLine(figura.GetArea());
        }
        














        //BaseClass bc = new BaseClass();
        //bc.Display1();
        //bc.Display2();

        //BaseClass dc2 = new DerivedClass();
        //dc2.Display1();
        //dc2.Display2();
        public class BaseClass
        {
            public virtual void Display1()
            {
                Console.WriteLine("Display1 in base class");
            }
            public void Display2()
            {
                Console.WriteLine("Display2 in base class");
            }
        }

        public class DerivedClass : BaseClass
        {
            public override void Display1()
            {
                Console.WriteLine("Display1 in derived class");
            }

            public void Display3()
            {
                Console.WriteLine("Display3 in derived class");
            }
        }
       
    }
}
