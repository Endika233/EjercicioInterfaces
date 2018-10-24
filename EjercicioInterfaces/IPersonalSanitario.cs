using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    interface IPersonalSanitario
    {
        void Mostrar();//Todo:Por ser itnerfaz añade el public e interfaz
        bool Jubilable();
        double CalculaSueldo();
    }
}
