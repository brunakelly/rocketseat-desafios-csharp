using System;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace Desafio
{
    public class Atividade5
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a placa de um veículo:");

            string placa = Console.ReadLine();

            bool placaValida = Regex.IsMatch(placa, @"^[A-Za-z]{3}[0-9]{4}$");

            Console.WriteLine(placaValida ? "Verdadeiro" : "Falso");
        }
    }
}
