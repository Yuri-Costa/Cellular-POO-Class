using System;

namespace Phone
{
    class Program
    {
        private static string senha;

        static void Main(string[] args)
        {
            Celular specifications = new Celular();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------------------");
            Console.WriteLine($"cor: {specifications.model} ");
            Console.WriteLine($"cor: {specifications.color} ");
            Console.WriteLine($"cor: {specifications.size} ");
            Console.WriteLine("--------------------------");
            Console.WriteLine();
            int opcao = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Selecione uma opção");
                if (specifications.on == false)
                {
                    Console.WriteLine("[1] - Ligar o celular");
                }
                else
                {
                    Console.WriteLine("[1] - Desligar o celular");
                }
                Console.WriteLine("[2] - Opções");
                Console.WriteLine("[0] - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        if(specifications.on == false){
                            specifications.Ligar();
                        }else{
                            specifications.Desligar();
                        }
                        break;
                    case 2:
                        if(specifications.on == true)
                        {
                            //fazer o menu com as opções
                             Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("--------Telefonar-------");
                            Console.WriteLine("-----Enviar mensagem-----");
                            Console.WriteLine("----------voltar----------");
                            string resposta = Console.ReadLine();
                            switch (resposta)
                            {
                                case "telefonar":
                                {specifications.FazerLigacao();}
                                    break;
                                case "enviar mensagem":
                                {specifications.EnviarMensagem();}
                                    break;

                                default:
                                    break;
                            }
                            //-------------------------------------------------
                        }else{
                            Console.WriteLine("Favor Ligar o Celular");
                        }
                        break;
                    case 0:

                        break;

                    default:
                        break;
                }



            } while (opcao != 0);









        }//end
    }
}
