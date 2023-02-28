using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnTriangulo
{
    internal class ClsTriangulo
    {
        //Declaracion de variables
        private double lado1;
        private double lado2;
        private double lado3;


     //Metodos
        public void Inicializar(double lado1, double lado2, double lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }

        
        public void LadoMayor()
        {
            if (lado1 > lado2 & lado1 > lado3)
            {
                Console.WriteLine("El lado  mayor es:" + lado1);
            }
            else if (lado2 > lado1 & lado2 > lado3)
            {
                Console.WriteLine("El lado  mayor es:" + lado2);
            }
            else
            {
                Console.WriteLine("El lado  mayor es:" + lado3);
            }
        }

        public bool Equilatero()
        {
            if (lado1 == lado2 && lado1 == lado3)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
