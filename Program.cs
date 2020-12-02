using System;

namespace Phone
{
    class Program
    {
        private static string senha;

        static void Main(string[] args)
        {
          Celular specifications = new Celular();
          Console.ForegroundColor=ConsoleColor.Cyan;
        Console.WriteLine("--------------------------");
        Console.WriteLine($"cor: {specifications.model} ");
        Console.WriteLine($"cor: {specifications.color} ");
        Console.WriteLine($"cor: {specifications.size} ");
        Console.WriteLine("--------------------------");
        Console.WriteLine();
         Console.ForegroundColor=ConsoleColor.Magenta;
        Console.WriteLine("-----------ações------------");
        Console.WriteLine("Desligar");
        Console.WriteLine("----------------");
        Console.WriteLine("Ligar");
        Console.WriteLine("----------------");
        Console.WriteLine("Enviar mensagem");
       Console.ForegroundColor=ConsoleColor.Green;
       string resposta = Console.ReadLine();

        //-----------------------------------------------------

        switch (resposta)
        {
            case "desligar": 
            { specifications.desligar();    
            }break;
        //-------------------------------------------------------

        case "ligar": 
            { specifications.fazerLigacao();     
            }break;
        //------------------------------------------------------

        case "enviar mensagem": 
            { specifications.enviarMensagem();     
            }break;
            default:
                break;
        }
        

        

    

        }//end
    }
}
