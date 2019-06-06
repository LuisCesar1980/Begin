using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoComWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            double numero, total = 0;
            string operacao = "+";

            while (operacao != "=")
            {
                Console.Write("Entre com o valor: ");
                numero = Convert.ToDouble(Console.ReadLine());

                switch (operacao)
                {
                    case "+": total = total + numero;
                        break;

                    case "-": total = total - numero;
                        break;

                    case "*": total = total * numero;
                        break;

                    case "/": total = total / numero;
                        break;
                }
                Console.Write("Digite a operação: ");
                operacao = Console.ReadLine();
            }
            Console.WriteLine("O resultado é: " + total);
            Console.ReadKey();
        }
    }
}
