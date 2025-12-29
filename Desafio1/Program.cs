using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha a atividade:");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Atividade1.Executar();
                    break;
                case "2":
                    Atividade2.Executar();
                    break;
                case "3":
                    Atividade3.Executar();
                    break;
                case "4":
                    Atividade4.Executar();
                    break;
                case "5":
                    Atividade5.Executar();
                    break;
                case "6":
                    Atividade6.Executar();
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}
