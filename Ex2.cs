namespace DesafioPráticoC_.ex2;
internal class Ex2
{
    public void execute()
    {
        Console.Write("Digite seu primeiro nome: ");
        string primeiroNome = Console.ReadLine().Trim();

        Console.Write("Digite seu sobrenome: ");
        string sobrenome = Console.ReadLine().Trim();

        Console.WriteLine($"Nome completo: {primeiroNome} {sobrenome}");
        
    }
}
