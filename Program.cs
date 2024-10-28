using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_POO__Clase_Persona_
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Ciudad { get; set; }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad} años");
            Console.WriteLine($"Ciudad: {Ciudad}");
        }

        public int CalcularEdadEnAnios()
        {
            return Edad;
        }
    }

}
