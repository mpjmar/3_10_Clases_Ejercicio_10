using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_10_Clases_Ejercicio_10
{
    internal class Cliente
    {
        string nombre;
        double cantidadTotal;

        public Cliente(string nombre)
        {
            this.nombre = nombre;
            this.cantidadTotal = 0;
        }

        public void Ingresar(double cantidad)
        {
            this.cantidadTotal += cantidad;
        }

        public void Sacar(double cantidad)
        {
            this.cantidadTotal -= cantidad;
        }

        public double GetCantidadTotal()
        {
            return this.cantidadTotal;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Saldo: {cantidadTotal}");
        }

    }
}
