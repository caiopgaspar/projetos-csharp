using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operação deseja fazer: ");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão \n");

            int operacao = int.Parse(Console.ReadLine());

            while (operacao < 1 || operacao > 4)
            {
                Console.WriteLine("\nERRO: Número de operação inválido\n");
                Console.Write("Digite o número da operação: ");

                operacao = int.Parse(Console.ReadLine());

            }

            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = 0;
            string nomeOperacao = "0";

            switch (operacao)
            {
                case 1:
                    {
                        resultado = Adicao(num1, num2);
                        nomeOperacao = "Adição";
                        break;
                    }

                case 2:
                    {
                        resultado = Subtracao(num1, num2);
                        nomeOperacao = "Subtração";
                        break;
                    }

                case 3:
                    {
                        resultado = Multiplicacao(num1, num2);
                        nomeOperacao = "Multiplicação";
                        break;
                    }

                case 4:
                    {
                        resultado = Divisao(num1, num2);
                        nomeOperacao = "Divisão";
                        break;
                    }

                default:
                    Console.WriteLine("Número inválido, digite outro número");
                    break;
            }

            Console.WriteLine("O resultado da operação {0} com os números {1} e {2} é: {3}", nomeOperacao, num1, num2, resultado);

            Console.ReadLine();
            

        }

        public static int Adicao (int numero1, int numero2)
        {
            int result = numero1 + numero2;
            return result;
        }

        public static int Subtracao(int numero1, int numero2)
        {
            int result = numero1 - numero2;
            return result;
        }

        public static int Multiplicacao(int numero1, int numero2)
        {
            int result = numero1 * numero2;
            return result;
        }

        public static int Divisao(int numero1, int numero2)
        {
            int result = numero1 / numero2;
            return result;
        }
    }
}
