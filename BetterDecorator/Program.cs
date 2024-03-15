using System;

namespace BetterDecorator
{
    class Program
    {
        static void Main(string[] args)
        {

            //Verifica se os argumentos foram passados
            if (args.Length < 3)
            {
                Console.WriteLine("Usage: dotnet run --project BetterDecorator -- \"<strings>\" \"<char>\" <int>");
                return;
            }

            // Extrai os argumentos da linha de comando
            string s = args[0]; //A string pode conter espaços
            char dec = args[1][0]; //O caracter é o primeiro da segunda string
            int repeatCount = int.Parse(args[2]); // Converta a 3ª string para um número inteiro

            // Imprime o resultado aplicando o método Decor
            Console.WriteLine(Decor(s, dec, repeatCount));
        }

        private static string Decor(string s, char dec, int repeatCount)
        {
            // Constrói o decorador
            string decorator = new string(dec, repeatCount);
            // Constrói a string
            return $"{decorator} {s} {decorator}";
        }
    }
}
