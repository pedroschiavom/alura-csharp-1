﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variaveis");

            int idade = 23;

            Console.WriteLine("idade: " + idade);

            idade = 10 + 5 * 2;

            Console.WriteLine(idade);

            idade = (10 + 5) * 2;
            Console.WriteLine("Sua idade é " + idade + " anos ! ");

            Console.WriteLine("Execução finalizada. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
