using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_10_Clases_Ejercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banco banco = new Banco();
            banco.Operar(100, 250, 400);
            banco.ObtenerEstado();
        }
    }
}
