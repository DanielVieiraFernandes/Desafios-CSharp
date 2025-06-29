

namespace DesafioPráticoC_.ex3;
internal class Ex3
{
    public void execute()
    {
        Console.Write("Digite o primeiro número: ");
        double n1 = double.Parse(Console.ReadLine());


        Console.Write("Digite o segundo número: ");
        double n2 = double.Parse(Console.ReadLine());

        Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
        Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
        Console.WriteLine($"{n1} x {n2} = {n1 * n2}");
        
        if(n1 == 0 ||  n2 == 0)
        {
            Console.WriteLine("Não é possível fazer divisão por zero");
        } else
        {
            Console.WriteLine($"{n1} : {n2} = {n1 / n2}");
        }

        Console.WriteLine($"Média entre os dois números: {(n1 + n2) / 2}");
    }
}
