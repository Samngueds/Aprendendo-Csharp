

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


            /// estrutura de if  e & else

            /*   if (10 > 2) 
               {

               }
                else 
               {

               }
               */

            //exemplo :

            int idade =  17;

          
            if (idade > 17) // se
            {
                Console.WriteLine("você e maior de idade");
            }
            else if (idade == 17) // se nao for mas..
            {
                Console.WriteLine("sua idaide e: " + idade);
            }
            else // se não
            {
                Console.WriteLine("você e menor de idade");
            }











            Console.ReadLine();
        }

    } // fim do progama
}
