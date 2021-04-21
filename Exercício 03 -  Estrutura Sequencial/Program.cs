using System;

namespace Exercício_03____Estrutura_Sequencial
{
    class Program
    {
        /// -------> START / MAIN.F 
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args){
            Msg();
            Formula();
        }
        /// -------> FUNCTIONS
        /////////////////////////////////////////////////////////////////////////////////////////////      
        static void Msg() {
            Console.WriteLine("Calculo da diferença do produto de A e B pelo produto de C e D ");
        }
        /*------------------------------------------------------------------------------------------*/
        static void Formula() {
            int a, b, c, d, diferenca;

            Console.Write("Digite o valor de A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de C: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de D: ");
            d = int.Parse(Console.ReadLine());

            diferenca = (a * b) - (c * d);
            Console.Write("A Diferença é: " +diferenca);
        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        /// -------> END
    }
}
