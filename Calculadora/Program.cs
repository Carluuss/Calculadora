    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Calculadora
    {
    internal class Program
    {
        public static bool verificarentrada (string opcao)
        {
            if(opcao == "s" || opcao == "c")
            {
                return true;
            }
            return false;

             
        }
        static double realizaroperacao (string opcao, double num1, double num2)
        {
          
           if(opcao == "+")
            {
                
                double resultado = num1 + num2; ;
                return resultado;



            }

            else if (opcao == "-")
            {
                
                double resultado = num1 - num2;
                return resultado;


            }
            else if (opcao == "x")
            {
                
                double resultado = num1 * num2;
                return resultado;


            }

            else if (opcao == ".")
            {
                
                double resultado = num1 / num2;
                return resultado;

                
            }
            else
            {
                return 0;
            }
           

        }

        static void inserirdados(string opcao)
        {
            Console.WriteLine("Digite o primeiro número: ");
            double valor1 = (Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Digite o segundo número: ");
            double valor2 = (Convert.ToDouble(Console.ReadLine()));
            double resultado2 = realizaroperacao(opcao, valor1, valor2);
            Console.WriteLine(" o resultado é: " + resultado2.ToString());
            Console.ReadKey(true);
            Console.Clear();
        }
        static void Main(string[] args)
        { string opcao;
            bool flag;
            
            do
            {
                Console.WriteLine("Digite C para usar a calculadora ou S para sair");
                opcao = Console.ReadLine().ToLower();


                if (opcao == "c")
                {
                    Console.WriteLine("Escolha qual operação você quer usar digite um desses simbolos para progredir:\n + \n - \n x \n .");
                    //opcao = (Console.ReadLine());
                    inserirdados(Console.ReadLine());

                }


                else if (opcao == "s")
                {
                    Console.ReadKey(true);

                }
                bool confirm;
                

                Console.WriteLine("Deseja continuar se sim digite S ou N para não continuar: ");
                 flag = Console.ReadLine().ToUpper() == "S" ? true : false;
            } while(verificarentrada(opcao) == false || flag == true);
            Console.WriteLine("Aperte qualquer tecla para sair");
            Console.ReadKey(true);
            
       
           

            

        }
    }
    }
