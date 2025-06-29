using System;
using System.Collections.Generic;


namespace DesafioPráticoC_.ex4;
internal class Ex4
{
    public void execute()
    {
        Console.Write("Digite uma ou mais palavras aleatórias: ");
        string entrada = Console.ReadLine().Trim().Replace(" ", ""); // Posso apenas fazer um replace para
                                                                     // que todos os espaços sejam excluidos

        // Soluções possíveis

        //int i = 0;

        //foreach (char item in entrada)
        //{
        //    i += item == ' ' ? 0 : 1;
        //}

        //Console.WriteLine($"Quantidade de caracteres: {i}");

        //int caracteres = 0;

        //for (int i = 0; i < entrada.Length; i++)
        //{
        //    if (entrada[i] != ' ')
        //    {
        //        caracteres++;
        //    }
        //}

        //Console.WriteLine($"Quantidade de caracteres: {caracteres}");


        Console.WriteLine($"Quantidade de caracteres: {entrada.Length}");

    }
}
