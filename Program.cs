using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forca
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] palavras = { "tucano,laranja,melancia,arara,uva,morcego" };
            Random sorteador = new Random();
            string palavraSorteada = palavras[sorteador.Next(0, palavras.Length)];

            Console.WriteLine("Bem-Vindo ao jogo da forca");
            Console.WriteLine("Para começar digite uma letra:");
            string letra = Console.ReadLine();
            bool palavraCompleta = false;

            while (true)
            {
                if (palavraSorteada.Contains(letra))
                {
                    Console.WriteLine($"A palavra sorteada contém a letra {letra}");
                }
                if (!palavraSorteada.Contains(letra))

                {
                    palavraCompleta = true;
                    break;
                }
                
                Console.WriteLine("Digite outra letra:");
                letra = Console.ReadLine();
                if (palavraCompleta)

                {
                    Console.WriteLine("Parabéns você venceu!");
                }
            }
        }
    }
}
