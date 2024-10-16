

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;







namespace Hellow_World
{
    class Program
    {
        static void Main(string[] args) //função principal , ela e executada primerio
        {
            // switch fuciona como um IF e else so que mais  objetivo
            string cor = "azul";

            switch(cor)
            {
                // serve pra definir um meio q  if
                case "vermelho":
                    Console.WriteLine("Sua cor favorita e vermelho");
                    break;// aqui fecha 
                case "azul":
                    Console.WriteLine("Sua cor favorita e Azul");
                    break;
                case "amarelo":
                    Console.WriteLine("Sua cor favorita e amarelo");
                    break;

                //tem a opção default ela server pra caso nem dos dado bata com o q  ta dentro do swicth

                default:
                    Console.WriteLine("não sei qual a sua  cor favorita");
                    break;
            }



            Console.WriteLine();


            Console.ReadLine();
        }
    } // fim do progama
}
