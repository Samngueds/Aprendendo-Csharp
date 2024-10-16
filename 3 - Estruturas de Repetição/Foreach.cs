

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
            // o metodo de repetição foreach serve pra percorrer arrays

            string[] palavras = { "livro", "pc", "bancada", "jogos", "notebook" };

            // pra percorrer um array tem q da  os detalhes dele
            // exemplo: 
            foreach (string palavra in palavras) //  para cada palavra no array, repita o bloco de codigo
                                                 // A variavel dada ali ela serve pra armazena os dados de cada  palavra, no caso de strings
            {
                Console.WriteLine(palavra); 
                
            }

            Console.WriteLine("fim da função");
            Console.ReadLine();
        }
    } // fim do progama
}
