using System.Globalization;

namespace Desafio
{
    public class Atividade6
    {
        public static void Executar()
        {
            Console.WriteLine("Escolha o formato de exibição de data desejado:" +
                "\n1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)" +
                "\n2 - Apenas a data no formato \"01/03/2024\"" +
                "\n3 - Apenas a hora no formato de 24 horas" +
                "\n4 - A data com o mês por extenso");

            string formatoDesejado = Console.ReadLine();

            DateTime hoje = DateTime.Now;

            switch (formatoDesejado)
            {
                case "1":
                    Console.WriteLine(hoje.ToString("dddd, dd/MM/yyyy HH:mm:ss"));
                    break;
                case "2":
                    Console.WriteLine(hoje.ToString("dd/MM/yyyy"));
                    break;
                case "3":
                    Console.WriteLine(hoje.ToString("HH:mm"));
                    break;
                case "4":
                    Console.WriteLine(hoje.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR")));
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            
        }
    }
}
