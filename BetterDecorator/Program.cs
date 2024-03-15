using System;

namespace BetterDecorator
{
    /// <summary>
    /// Um programa que decora uma string
    /// </summary>
    class Program
    {
        /// <summary>
        /// Programa principal
        /// </summary>
        /// <param name="args">Os argumentos da linha de comandos.</param>
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

        /// <summary>
        /// Decora uma string
        /// </summary>
        /// <param name="s">A string é decorada.</param>
        /// <param name="dec">É usado um caracter.</param>
        /// <param name="repeatCount">Número de repetições.</param>
        /// <returns>String decorada.</returns>
        private static string Decor(string s, char dec, int repeatCount)
        {
            // Constrói o decorador
            string decorator = new string(dec, repeatCount);
            // Constrói a string
            return $"{decorator} {s} {decorator}";
        }
    }
}
