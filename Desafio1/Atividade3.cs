using System;
using System.Xml.Linq;

namespace Desafio
{
    public class Atividade3
    {
        public static void Executar()
        {
            double valor1 = 1.5;
            double valor2 = 5.5;
            double soma = valor1 + valor2;
            double subtracao = valor1 - valor2;
            double multiplicacao = valor1 * valor2;
            double divisao = valor2 == 0  ? 0 : valor1 / valor2;
            double media = soma / 2;

            Console.WriteLine($"Soma: {soma}\nSubtração: {subtracao}\nMultiplicação: {multiplicacao}\nDivisão: {divisao}\nMédia: {media}");
        }
    }
}
