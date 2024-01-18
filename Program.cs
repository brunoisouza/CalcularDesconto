using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularDesconto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Crie um programa que solicite o valor de um produto. 
                Após isso deve ser solicitado a porcentagem de desconto para o produto. 
                Deve ser mostrado o valor com desconto ao final do processo.

                Regras:
                - A taxa de desconto não pode ser maior que 50%
                - A taxa de desconto não pode ser menor que 0%
                - A taxa de desconto não pode ser maior que 10% caso o valor do produto seja menor que 100 reais.
                - A taxa de desconto não pode ser maior que 20% caso o valor do produto seja menor que 200 reais.
            */

            // Mensagem de abertura
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("***      DESCONTO DE VALOR DO PRODUTO      ***");
            Console.WriteLine("----------------------------------------------");

            // verificar a senha do usuário
            Console.WriteLine("Informe a senha para continuar: ");
            string senha = Console.ReadLine();

            if (senha != "abacaxi1")
            {
                Console.WriteLine("Senha Incorreta!");
                Console.ReadKey();
                Environment.Exit(0);
            }

            // Limpar a tela
            Console.Clear();

            // Solicitar o valor do produto
            Console.WriteLine("Informe o valor do produto: ");
            decimal valorProduto = decimal.Parse(Console.ReadLine());

            // Solicitar e Verificar as condições de desconto 
            decimal percentualDesconto = 0;
            int valorAceito = 0;

            while (valorAceito == 0)
            {
                // Solicitar o valor do desconto
                Console.WriteLine("Informe o valor do desconto: ");
                percentualDesconto = decimal.Parse(Console.ReadLine());

                // Verificar condições do desconto
                if (percentualDesconto > 50)
                    Console.WriteLine($"O Valor do Desconto não pode ser maior que 50%. Valor produto {valorProduto}, percentual de desconto informado: {percentualDesconto}.");
                else if (percentualDesconto < 0)
                    Console.WriteLine($"O Valor do Desconto não pode ser menor que 0. Valor produto {valorProduto}, percentual de desconto informado: {percentualDesconto}.");
                else if (valorProduto < 100 && percentualDesconto > 10)
                    Console.WriteLine($"A taxa de desconto não pode ser maior que 10% caso o valor do produto seja menor que 100 reais. Valor produto {valorProduto}, percentual de desconto informado: {percentualDesconto}.");
                else if (valorProduto < 200 && percentualDesconto > 20)
                    Console.WriteLine($"A taxa de desconto não pode ser maior que 20% caso o valor do produto seja menor que 200 reais. Valor produto {valorProduto}, percentual de desconto informado: {percentualDesconto}.");
                else
                    valorAceito = 1;
            }

            // Calcular valor do produto com desconto
            decimal produtoComDesconto = valorProduto - ((valorProduto * percentualDesconto) / 100);

            //Mostrar o valor do desconto
            Console.WriteLine($"O valor original do produto era R$ {valorProduto}, após o desconto de {percentualDesconto}%, passou a ser R${produtoComDesconto}");

            //Esperar qualquer tecla
            Console.ReadKey();

        }
    }
}