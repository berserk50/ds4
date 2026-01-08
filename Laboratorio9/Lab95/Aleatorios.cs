using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab95
{
 
        internal class Aleatorios
        {
            Random rnd = new Random();

            public int GenerarNumero()
            {
                int numeroGenerado = rnd.Next(1, 21);

                return numeroGenerado;
            }

            public int[] GenerarArreglo()
            {

                int[] arregloNum = new int[4];
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

        public int[] GenerarNoRepetido()
        {
            int[] arregloNumNoRepet = new int[4];

            for (int i = 0; i < arregloNumNoRepet.Length; i++)
            {
                int num;
                bool repetido = true; // Iniciar en true para entrar al bucle

                while (repetido)
                {
                    num = GenerarNumero();
                    repetido = false; // Asumir que no está repetido

                    // Verificar si el número ya existe
                    for (int j = 0; j < i; j++)
                    {
                        if (arregloNumNoRepet[j] == num)
                        {
                            repetido = true; // Está repetido, seguir buscando
                            break;
                        }
                    }

                    // Si no está repetido, asignarlo al array
                    if (!repetido)
                    {
                        arregloNumNoRepet[i] = num;
                    }
                }
            }

            return arregloNumNoRepet;
        }


    }

}
