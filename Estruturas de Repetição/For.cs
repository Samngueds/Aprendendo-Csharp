

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
            // o metodo de repetição for tambem serve pra percorrer arrays
            // a for pode e basicamente um while + foreach


            string[] palavras = { "pc", "refri", "soverte", "livro", "dinosauro" };


               for (int contador = 0; contador < palavras.Length; contador++)// basicamente ele compacta um while
                {
                Console.WriteLine(contador + 1);
                Console.WriteLine(palavras[contador]);// aqui ele chama o arry e  usa  a variavel contador pra acessar o indice
                }


            Console.WriteLine("====================================");


            for (int contador2 = palavras.Length -1; contador2 >= 0; contador2--) // length pega o tamanho de um array automaticamente com  menos um  ele pega o tamnaho dos objetos dentro do array
            {        //assim ele faz o for pecorrer o array ao contrario
                Console.WriteLine(contador2 + 1);
                Console.WriteLine(palavras[contador2]);
            }

            Console.WriteLine("fim da função");
            Console.ReadLine();
        }
    } // fim do progama
}
