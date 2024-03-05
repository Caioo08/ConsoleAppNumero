using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double conta;

            Console.Write("Digite um número: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a operação(*,-,/,+): ");
            string oper = Console.ReadLine();

            if (oper == "*")
            {
                conta = n1 * n2;
                Console.WriteLine("O resultado será: " + conta);
                Console.ReadKey();
            }

            else if (oper == "+")
            {
                conta = n1 + n2;
                Console.WriteLine("O resultado será: " + conta);
                Console.ReadKey();
            }
            else if (oper == "-")
            {
                conta = n1 - n2;
                Console.WriteLine("O resultado será: " + conta);
                Console.ReadKey();
            }
            else if(oper == "/")
            {
                conta = n1 / n2;
                Console.WriteLine("O resultado será: " + conta);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Operação inexistente");
                Console.ReadKey();
            }
        }
    }
}
