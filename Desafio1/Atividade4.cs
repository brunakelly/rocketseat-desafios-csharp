using System;
using System.Xml.Linq;

namespace Desafio
{
    public class Atividade4
    {
        public static void Executar()
        {
            Console.WriteLine("Escreva um texto:");

            string texto = Console.ReadLine();

            int quantidadeCaracteres = texto.Length;

            Console.WriteLine($"Seu texto tem {quantidadeCaracteres} caracteres");
        }
    }
}
