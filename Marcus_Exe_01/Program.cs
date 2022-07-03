using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcus_Exe_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            int soma3 = 0;
            int soma5 = 0;
            int usuario = 0;

            Console.Write("Informar o valor máximo para calcular os multiplos de 3 e 5! \n");
            Console.WriteLine("Qual o valor máximo para calcular?");
            usuario = Convert.ToInt32(Console.ReadLine());


            for (int numero = 1; numero <= usuario; numero++)
            {
                if (numero % 3 == 0)

                    soma3 = soma3 + numero;
            }

            for (int numero = 1; numero <= usuario; numero++)
            {
                if (numero % 5 == 0)

                    soma5 = soma5 + numero;
            }

            soma = soma3 + soma5;


            

            Console.WriteLine(string.Format("O resultado da soma dos multiplos de 3 e 5 é: {0}\n", soma));
            Console.Write("Pressione alguma tecla!");
            Console.ReadKey();



        }
        
        
    }
}
