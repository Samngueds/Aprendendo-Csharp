

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;







namespace Hellow_World
{
    class Program
    {


        //enum fuciona tipo um array mais limitado aos valores dados, e   eles ja vem indexados com numerações automatica

        //exemplo

        enum cor { azul = 1, verde, rosa, vermelho }


        // pra voce extrair os valores, vc tem q chama  ele tipo  uma função e depois da variavel



        static void Main(string[] args) //função principal , ela e executada primerio
        {


            // e possivel mistura enum com switchs

            //exemplo :

            Console.WriteLine("escolha sua cor favorita abaixo: ");
            Console.WriteLine("1 - Azul\n2 - verde\n3 - rosa\n4 - vermelho");

            // menu criado agora pra o swtich fuciona com o enum e nessesario converte a string capturada do usuario pra numero

            int index = int.Parse(Console.ReadLine());
            // agora se cia uma variavel com o enum pra receber os dados

            cor option = (cor)index;

            //agora temos que chama a cor e os dados do enum do switch

            switch (option)
            {
                // no caso tem q por os dados do emu
                case cor.vermelho:
                    Console.WriteLine("Sua cor favorita e vermelho");
                    break;
                case cor.azul:
                    Console.WriteLine("Sua cor favorita e Azul");
                    break;
                case cor.rosa:
                    Console.WriteLine("Sua cor favorita e rosa");
                    break;
                case cor.verde:
                    Console.WriteLine("Sua cor favorita e verde");
                    break;

                //tem a opção default ela server pra caso nem dos dado bata com o q  ta dentro do swicth

                default:
                    Console.WriteLine("Escolha umas da cores acima");
                    break;
            }








            Console.ReadLine();
        }
    } // fim do progama
}
