using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab94
{
    internal class Aleatorios
    {
        Random rnd= new Random();

        public int GenerarNumero() {
            int numeroGenerado = rnd.Next(1, 21);
        
            return numeroGenerado;
        }

        public int[] GenerarArreglo() { 
        
            int[] arregloNum =  new int[4];
            int num1 = GenerarNumero();
            int num2 = GenerarNumero();

            for (int i = 0; i < arregloNum.Length; i++)
            {
                int numeroRandom = rnd.Next((num1), (num2));
                arregloNum[i] = numeroRandom;
                Console.WriteLine(arregloNum[i]);
                
            }

            return arregloNum;
        }

    }
}
