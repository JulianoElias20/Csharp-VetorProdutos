using System;
using VetorOO;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos produtos deseja cadastrar? ");
            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];

            for(int i=0; i < n; i++)
            {
                Console.WriteLine("Digite o nome do produto: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o preço do produto: ");
                double preco = double.Parse(Console.ReadLine());

                vect[i] = new Produto(nome, preco);
                
            }

            double soma = 0;

            for(int i= 0; i<n;i++)
            {
                soma += vect[i].Preco;
                //Console.WriteLine(vect[i].Nome+" "+ vect[i].Preco);

            }

            double media = soma / n;

            Console.WriteLine("A média é "+media.ToString("F2"));


        }
    }
}
