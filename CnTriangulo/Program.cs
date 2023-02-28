using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnTriangulo
{
    internal class Program
    {
        /// <summary>
        /// Nombre:Viviana Muñoz
        /// Fecha:26/02/2023
        /// Descripcion:Programa que solicita los tres lados de un triangulo e imprime el lado mayor y si es equilatero.
        /// </summary>
        static void Main(string[] args)
        {
            //Instancia de clase
            ClsTriangulo triangulo = new ClsTriangulo();

            //Solicita datos
            double lado1, lado2, lado3;
            Console.Write("Ingrese el lado 1: ");
            lado1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el lado 2: ");
            lado2 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el lado 3: ");
            lado3 = double.Parse(Console.ReadLine());

            //Llamada de metodos
            triangulo.Inicializar(lado1, lado2, lado3);
            triangulo.LadoMayor();

            //Condicion
            if (triangulo.Equilatero())
            {
                Console.WriteLine("El triángulo es equilátero.");
            }
            else
            {
                Console.WriteLine("El triángulo no es equilátero.");
            }

            Console.ReadLine();
        }
    }
}
