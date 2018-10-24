using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    class Enfermero:Sanitario,IPersonalSanitario
    {
        private string puesto;
        public Enfermero(string dni, string nombre, double sueldoBase, int edad):base(dni, nombre, sueldoBase, edad)
        {

        }
        public Enfermero(string dni, string nombre, double sueldoBase, int edad,string puesto) : base(dni, nombre, sueldoBase, edad)
        {
            this.puesto = puesto.ToUpper();
        }
        public void GetPuesto(string puesto)
        {
            this.puesto = puesto.ToUpper();
        }
        public override double CalculaSueldo()
        {
            return base.CalculaSueldo()+sueldoExtra();
        }
        public double sueldoExtra()
        {
            if (puesto == "UCI")
            {
                return 200;
            }
            return 0;
        }
        public override void Mostrar()
        {
            Console.WriteLine("\t\tEnfermero\n-------------------------------\nPuesto: " + puesto);//Bucle
            base.Mostrar();
            Console.WriteLine("Sueldo con extras: " + CalculaSueldo());
        }
    }
}
