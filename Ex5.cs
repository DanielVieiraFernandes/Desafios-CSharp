

namespace DesafioPráticoC_.ex5;
internal class Ex5
{

    public void execute()
    {
        Console.Write("Digite a placa de seu veículo: ");
        string placa = Console.ReadLine().Trim();

        if(placa.Length != 7)
        {
            Console.WriteLine(false);
            return;
        }

        for (int i = 0; i < placa.Length; i++)
        {
            if (i < 3 && !char.IsLetter(placa[i])){
                Console.WriteLine(false);
                return;
            }

            if(i > 3 && !char.IsDigit(placa[i]))
            {
                Console.WriteLine(false);
                return;
            }
        }

        Console.WriteLine(true);

    }
}
