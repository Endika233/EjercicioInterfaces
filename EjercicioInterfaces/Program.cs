using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Medico m1 = new Medico("2135438a","Paco",2000.45,42,"Frenólogo",95);
            Medico m2 = new Medico("29895848z", "Don PinPon", 2265.70, 70, "Urólogo", 195);
            Enfermero e1 = new Enfermero("6844684684a", "Txumatxo", 1200.25, 28);
            e1.GetPuesto("uci");
            Enfermero e2 = new Enfermero("63896932L", "Mutxomatxo", 1600.98, 66,"planta");
            Enfermero e3 = new Enfermero("7279272M", "Antonia", 1848.5, 35,"uci");
            List<Sanitario> personal = new List<Sanitario> {m1,m2,e1,e2,e3 };
            foreach (var item in personal)
            {
                item.Mostrar();
                if (item.Jubilable())
                {
                    Console.WriteLine("****El empleado puede jubilarse ya");
                }
            }
            foreach (var item in personal)
            {
                item.AumentarSueldoPorCiento(1);
                item.Mostrar();
                if (item.Jubilable())
                {
                    Console.WriteLine("****El empleado puede jubilarse ya");
                }
            }
            foreach (var item in personal)
            {                
                if (item.Jubilable())
                {
                    item.Mostrar();
                }
            }
            

            Console.ReadLine();
        }
    }
}
