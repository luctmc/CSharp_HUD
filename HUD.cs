using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Projeto LUC

            String MensagemDeBoasVindas = (@"

██████╗░██████╗░░█████╗░░░░░░██╗███████╗████████╗░█████╗░  ░░░░░░  ██╗░░░░░██╗░░░██╗░█████╗░
██╔══██╗██╔══██╗██╔══██╗░░░░░██║██╔════╝╚══██╔══╝██╔══██╗  ░░░░░░  ██║░░░░░██║░░░██║██╔══██╗
██████╔╝██████╔╝██║░░██║░░░░░██║█████╗░░░░░██║░░░██║░░██║  █████╗  ██║░░░░░██║░░░██║██║░░╚═╝
██╔═══╝░██╔══██╗██║░░██║██╗░░██║██╔══╝░░░░░██║░░░██║░░██║  ╚════╝  ██║░░░░░██║░░░██║██║░░██╗
██║░░░░░██║░░██║╚█████╔╝╚█████╔╝███████╗░░░██║░░░╚█████╔╝  ░░░░░░  ███████╗╚██████╔╝╚█████╔╝
╚═╝░░░░░╚═╝░░╚═╝░╚════╝░░╚════╝░╚══════╝░░░╚═╝░░░░╚════╝░  ░░░░░░  ╚══════╝░╚═════╝░░╚════╝░

");

            void ExibirMensagemDeBoasVindas()
            {

                Console.WriteLine(MensagemDeBoasVindas);
                Console.WriteLine("\nSeja Bem-Vindo ao Projeto LUC");
            }

            ExibirMensagemDeBoasVindas();

            void ExibirMensagemDoMenu()
            {
                Console.WriteLine("\nDigite 1 para Acessar a Calculadora");
                Console.WriteLine("Digite 2 para sair do Menu ");

                Console.Write("\nDigite a Opcao Escolida:");
                string opcaoEscolida = Console.ReadLine();
                int opcaoEscolidaNumerica = int.Parse(opcaoEscolida);


                void VariantesOpcoes()
                {
                    Console.WriteLine("Opcao Selecionada: " + opcaoEscolida);
                }


                void Calculadora()
                {


                    Console.WriteLine("Bem-vindo à Calculadora em C#");
                    Console.WriteLine("Escolha a operação:");
                    Console.WriteLine("1 - Adição");
                    Console.WriteLine("2 - Subtração");
                    Console.WriteLine("3 - Multiplicação");
                    Console.WriteLine("4 - Divisão");

                    Console.Write("Digite o número da operação desejada: ");
                    int opcao = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Digite o primeiro número: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    double resultado = 0;

                    switch (opcao)
                    {
                        case 1:
                            resultado = num1 + num2;
                            Console.WriteLine($"Resultado: {num1} + {num2} = {resultado}");
                            break;
                        case 2:
                            resultado = num1 - num2;
                            Console.WriteLine($"Resultado: {num1} - {num2} = {resultado}");
                            break;
                        case 3:
                            resultado = num1 * num2;
                            Console.WriteLine($"Resultado: {num1} × {num2} = {resultado}");
                            break;
                        case 4:
                            if (num2 != 0)
                            {
                                resultado = num1 / num2;
                                Console.WriteLine($"Resultado: {num1} ÷ {num2} = {resultado}");
                            }
                            else
                            {
                                Console.WriteLine("Erro: Divisão por zero não permitida.");
                            }
                            break;
                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                }

                switch (opcaoEscolidaNumerica)
                {
                    case 1:
                        VariantesOpcoes();
                        Console.Clear();
                        Calculadora();
                        break;
                    case 2:
                        VariantesOpcoes();
                        break;
                    default:
                        Console.WriteLine("Opcao Invalida");
                        break;





                }


            }

            ExibirMensagemDoMenu();

            Console.ReadLine();
        }
    }
}
