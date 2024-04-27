

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

        enum cor { azul, verde, rosa, vermelho }


        // pra voce extrair os valores, vc tem q chama  ele tipo  uma função e depois da variavel



        static void Main(string[] args) //função principal , ela e executada primerio
        {
            

        cor corfavorita = cor.azul;
        cor corfavorita2 = cor.rosa;


            Console.WriteLine(corfavorita);

            //e possivel  converter um  enum  pra numero
            Console.WriteLine((cor)2);







            Console.ReadLine();
        }
    } // fim do progama
}
