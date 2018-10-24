using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    class Medico:Sanitario
    {
        private int pacientes;
        string especialidad;
        private const double precioPaciente = 1.2;
        public Medico(string dni,string nombre,double sueldoBase,int edad,string especialidad) : base(dni, nombre, sueldoBase, edad)
        {
            this.especialidad = especialidad;
        }
        public Medico(string dni, string nombre, double sueldoBase, int edad, string especialidad, int pacientes) : base(dni, nombre, sueldoBase, edad)
        {
            this.especialidad = especialidad;
            this.pacientes = pacientes;
        }
        public void GetPacientes(int pacientes)
        {
            this.pacientes = pacientes;
        }
        public override double CalculaSueldo()
        {
            return base.CalculaSueldo()+ (pacientes * precioPaciente);
        }
        public override void Mostrar()
        {
            Console.WriteLine("\t\tMédico\n-------------------------------\nEspecialidad: " + especialidad);//Bucle
            base.Mostrar();
            Console.WriteLine("Sueldo con extras: " + CalculaSueldo());
        }
    }
}
