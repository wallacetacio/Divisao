using System;

namespace Divisao
{
    class Program
    {
        static void Main(string[] args)
        {

            double num, den, result;

            Console.Write("Digite o numerador...: ");
            num = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o denominador.: ");
            den = Convert.ToDouble(Console.ReadLine());

            if(den == 0){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Não é possível dividir por zero.");
                Console.ResetColor();
            }
            else
            {
                result = num / den;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{num} dividido por {den} é igual a: {result:N2}");
                Console.ResetColor();
            }
            }
    }
}
