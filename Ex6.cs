

using System.Globalization;

namespace DesafioPráticoC_.ex6;
internal class Ex6
{
    public void execute()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

        Console.WriteLine("Selecione um formato para a exibição da data atual: ");
        Console.WriteLine("Digite o número referente a opção");
        Console.WriteLine("\n 1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).");
        Console.WriteLine("2 - Apenas a data no formato \"01/03/2024\".");
        Console.WriteLine("3 - Apenas a hora no formato de 24 horas.");
        Console.WriteLine("4 - A data com o mês por extenso.");
        Console.Write("Opção: ");
        sbyte opt = sbyte.Parse(Console.ReadLine());

        switch (opt) {

            case 1:
                {
                    Console.WriteLine(DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy, HH:mm:ss"));
                    break;
                }
            case 2:
                {
                    Console.WriteLine(DateTime.UtcNow.ToString(new CultureInfo("pt-BR")));
                    break;
                }
            case 3:
                {
                    Console.WriteLine(DateTime.UtcNow.ToLongTimeString());
                    break;
                }
            case 4:
                {
                    Console.WriteLine(new DateTime().Month.ToString(new CultureInfo("pt-BR")));
                    break;
                }

            default:
                {
                    Console.WriteLine("Opção inválida"); break;
                }

        } 


    }
}
