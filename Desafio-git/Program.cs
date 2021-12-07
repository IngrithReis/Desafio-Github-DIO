using Desafio_git.Entities;
using Desafio_git.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Desafio_git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Carro> carros = new List<Carro>();

            Console.WriteLine("Quantos carros deseja cadastrar?");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.Write("Marca do #" + i + " carro: ");
                string marca = Console.ReadLine();

                Console.Write("Cor do #"+i+  " carro: ");
                string cor = Console.ReadLine();

                Console.Write("Ano do #"+i + " carro (YYYY): ");
                string respostaAno = (Console.ReadLine());

                try
                {

                    DateTime ano = DateTime.ParseExact(respostaAno, "yyyy", CultureInfo.InvariantCulture);
                    var carro = new Carro
                    {
                        ID = i,
                        Marca = marca,
                        Ano = ano,
                        Cor = cor
                    };
                    carros.Add(carro);
                    Console.WriteLine();
                }
                catch (AnoInputException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
                catch(FormatException fm)
                {
                    Console.WriteLine("Fomrmatro inserido inválido! O ano deve conter 4 números");
                    return;
                }
            }
            foreach (Carro carro in carros)
            {
                Console.WriteLine(carro);
            }

        }
    }
}
