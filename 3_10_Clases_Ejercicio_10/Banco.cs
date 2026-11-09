using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_10_Clases_Ejercicio_10
{
    internal class Banco
    {
        double fondos = 0;
        Cliente cliente1;
        Cliente cliente2;
        Cliente cliente3;

        public Banco()
        {
            cliente1 = new Cliente("Cliente 1");
            cliente2 = new Cliente("Cliente 2");
            cliente3 = new Cliente("Cliente 3");
        }

        public void Operar(double cant1, double cant2, double cant3)
        {
            cliente1.Ingresar(cant1);
            cliente2.Ingresar(cant2);
            cliente3.Ingresar(cant3);
            this.fondos += cant1 + cant2 + cant3;
        }

        public void ObtenerEstado()
        {
            Console.WriteLine($"Total dinero ingresado: {fondos}");
            Console.WriteLine($"Dinero ingresado por Cliente 1: " + cliente1.GetCantidadTotal());
            Console.WriteLine($"Dinero ingresado por Cliente 2: " + cliente2.GetCantidadTotal());
            Console.WriteLine($"Dinero ingresado por Cliente 3: " + cliente3.GetCantidadTotal());
        }
    }
}
