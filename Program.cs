using System;

namespace Phone
{
    class Program
    {
        private static string senha;

        static void Main(string[] args)
        {
          Celular specifications = new Celular();
        Console.WriteLine("--------------------------");
        Console.WriteLine($"cor: {specifications.model} ");
        Console.WriteLine($"cor: {specifications.color} ");
        Console.WriteLine($"cor: {specifications.size} ");
        Console.WriteLine("--------------------------");
        Console.WriteLine();
        Console.WriteLine("-----------ações------------");
        Console.WriteLine("Desligar");
        Console.WriteLine("----------------");
        Console.WriteLine("Fazer Ligação");
        Console.WriteLine("----------------");
        Console.WriteLine("Enviar mensagem");

       string resposta = Console.ReadLine();

        //-----------------------------------------------------

        switch (resposta)
        {
            case "desligar": 
            { Console.WriteLine($"{specifications.desligar}");     
            }
                break;
            default:
                break;
        }
        

        

    

        }//end
    }
}
