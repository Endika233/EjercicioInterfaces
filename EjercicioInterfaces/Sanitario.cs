using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    class Sanitario : IPersonalSanitario
    {
        private string dni, nombre;
        private double sueldoBase;
        private bool jubilable;
        private int edad;
        public Sanitario()
        {

        }
        public Sanitario(string dni,string nombre,double sueldoBase,int edad)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.sueldoBase = sueldoBase;
            this.edad = edad;
        }
        public virtual void Mostrar()
        {
            Console.WriteLine("Nombre: " + nombre + "\nDni: " + dni + "\nEdad: " + edad + "\nSueldo Base: " + sueldoBase);
        }
        public bool Jubilable()
        {
            if (edad >= 65)
            {
                jubilable = true;
            }
            return jubilable;
        }
        public virtual double CalculaSueldo()
        {
            return sueldoBase;
        }
        public void AumentarSueldoPorCiento(int porCiento)
        {
            this.sueldoBase=sueldoBase*( (Convert.ToDouble(porCiento) + 100) / 100);
           
        }
    }
}
