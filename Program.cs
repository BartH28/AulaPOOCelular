using System;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular samsung = new Celular();
            bool retorno = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($@"
______________________________
|  ________________________  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |   Digite o numero    |  |
|  |                      |  |
|  |         '1'          |  |
|  |                      |  |
|  | para ligar o celular |  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |______________________|  |
|             []             |
|____________________________|
                ");

                int respotaL = int.Parse(Console.ReadLine());

                switch (respotaL)
                {
                    case 1:
                        samsung.Ligar();
                        if (samsung.ligado == true)
                        {


                            retorno = false;
                            Console.WriteLine($@"
______________________________
|  ________________________  |
|  |                      |  |
|  |   Digite o numero    |  |
|  |                      |  |
|  |         '1'          |  |
|  |                      |  |
|  | para Enviar mensagem |  |
|  |                      |  |
|  |         '2'          |  |
|  |                      |  |
|  |    para Fazer uma    |  |
|  |        ligaçao       |  |
|  |                      |  |
|  |         '3'          |  |
|  |                      |  |
|  |     para desligar    |  |
|  |                      |  |
|  |______________________|  |
|             []             |
|____________________________|
                ");
                            bool retornarW = false;
                            do
                            {


                                int respostab = int.Parse(Console.ReadLine());
                                if (respostab == 1)
                                {

                                    Console.ForegroundColor = ConsoleColor.Green;

                                    Console.WriteLine($@"
______________________________
|  ________________________  |
|  |                      |  |
|  |  Whatsapp Premium 2  |  |
|  | ____________________ |  |
|  |  Contatos            |  |
|  | ____________________ |  |
|  |                      |  |
|  |  Mãe                 |  |
|  |  (11)98343513        |  |
|  |  Pai                 |  |
|  |  (11)93244592        |  |
|  |  Vô                  |  |
|  |  (11)97743345        |  |
|  |  Cachorro            |  |
|  |  (11)92342566        |  |
|  |  Papagaio            |  |
|  |  (11)95554443        |  |
|  |______________________|  |
|             []             |
|____________________________|
                ");
                                    Console.WriteLine("Escolha um contato");
                                    string contato = Console.ReadLine();
                                    switch (contato)
                                    {
                                        case "Mãe":
                                            Console.WriteLine(samsung.Enviarmsg());
                                            Console.WriteLine("VAI LAVA A LOÇA");
                                            retorno = true;
                                            break;
                                        case "Pai":
                                            Console.WriteLine(samsung.Enviarmsg());
                                            Console.WriteLine($@"ok");
                                            retorno = true;
                                            break;
                                        case "Vô":
                                            Console.WriteLine(samsung.Enviarmsg());
                                            Console.WriteLine("Amem netinho(a) ");
                                            retorno = true;
                                            break;
                                        case "Cachorro":
                                            Console.WriteLine(samsung.Enviarmsg());
                                            Console.WriteLine("AU AUA UA AU ");
                                            retorno = true;
                                            break;
                                        case "Papagaio":
                                            Console.WriteLine(samsung.Enviarmsg());
                                            Console.WriteLine("O papagaio repitiu o que voce disse:  '" + samsung.msg + "'");
                                            retorno = true;
                                            break;
                                        default:
                                            retorno = true;
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("DIGITE UMA OPÇÃO VALIDA");
                                            Console.ResetColor();
                                            break;
                                    }

                                }
                                else if (respostab == 2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    samsung.Fazerligação();
                                     Console.WriteLine($@"
______________________________
|  ________________________  |
|  |                      |  |
|  |  Ligação             |  |
|  | ____________________ |  |
|  |  Contatos            |  |
|  | ____________________ |  |
|  |                      |  |
|  |  Mãe                 |  |
|  |  (11)98343513        |  |
|  |  Pai                 |  |
|  |  (11)93244592        |  |
|  |  Vô                  |  |
|  |  (11)97743345        |  |
|  |  Cachorro            |  |
|  |  (11)92342566        |  |
|  |  Papagaio            |  |
|  |  (11)95554443        |  |
|  |______________________|  |
|             []             |
|____________________________|
                ");
                                        Console.WriteLine("Escolha um contato");
                                    string contato = Console.ReadLine();
                                    switch (contato)
                                    {
                                        case "Mãe":
                                            Console.WriteLine(samsung.Fazerligação());
                                            Console.WriteLine($@"
______________________________
|  ________________________  |
|  |                      |  |
|  |______________________|  |
|  |         Mãe          |  |
|  |______________________|  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |      Chamando...     |  |
|  |                      |  |
|  |     (pipipi)         |  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |______________________|  |
|             []             |
|____________________________|
                ");                          
                                            retorno = true;
                                            break;
                                        case "Pai":
                                            Console.WriteLine(samsung.Fazerligação());
                                            Console.WriteLine($@"
______________________________
|  ________________________  |
|  |                      |  |
|  |______________________|  |
|  |         Pai          |  |
|  |______________________|  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |      Chamando...     |  |
|  |                      |  |
|  |     (pipipi)         |  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |______________________|  |
|             []             |
|____________________________|
                ");  
                                            retorno = true;
                                            break;
                                        case "Vô":
                                            Console.WriteLine(samsung.Fazerligação());
                                            Console.WriteLine($@"
______________________________
|  ________________________  |
|  |                      |  |
|  |______________________|  |
|  |          Vô          |  |
|  |______________________|  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |      Chamando...     |  |
|  |                      |  |
|  |     (pipipi)         |  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |______________________|  |
|             []             |
|____________________________|
                ");  
                                            retorno = true;
                                            break;
                                        case "Cachorro":
                                            Console.WriteLine(samsung.Fazerligação());
                                            Console.WriteLine($@"
______________________________
|  ________________________  |
|  |                      |  |
|  |______________________|  |
|  |       Cachorro       |  |
|  |______________________|  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |      Chamando...     |  |
|  |                      |  |
|  |     (pipipi)         |  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |______________________|  |
|             []             |
|____________________________|
                ");  
                                            retorno = true;
                                            break;
                                        case "Papagaio":
                                            Console.WriteLine(samsung.Fazerligação());
                                            Console.WriteLine($@"
______________________________
|  ________________________  |
|  |                      |  |
|  |______________________|  |
|  |       Papagaio       |  |
|  |______________________|  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |      Chamando...     |  |
|  |                      |  |
|  |     (pipipi)         |  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |                      |  |
|  |______________________|  |
|             []             |
|____________________________|
                ");  
                                            retorno = true;
                                            break;
                                        default:
                                            retorno = true;
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("DIGITE UMA OPÇÃO VALIDA");
                                            Console.ResetColor();
                                            break;
                                    }
                                }
                                else if (respostab == 3)
                                {
                                    samsung.Desligar();
                                    Console.WriteLine("O Celular foi desligado");
                                    retorno = true;

                                }
                                else
                                {
                                    retorno = true;
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("DIGITE UMA OPÇÃO VALIDA");
                                    Console.ResetColor();
                                }
                            } while (retornarW);
                        }
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("DIGITE UMA OPÇÃO VALIDA");
                        Console.ResetColor();
                        retorno = true;
                        break;
                }
            } while (retorno);

        }
    }
}
