

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


            //while ele repete uma condição enquanto for true

            //exemplo :

            int contador = 0; //aqui o contador esta definido como 0

            while (contador < 10)
            {// aqui e basicamente se o contador for meno  de 10 repita  isso, basicamente como o  contador não esta contado
             // e a varivel esta estatica no mesmo valor sempre vai ser meno que  10 e  vai entra em loop

                // Console.WriteLine(contador); dessa forma ele entra em loop

                Console.WriteLine(contador + 1); // assim visualmente ele vai conta aparti do um
                // Console.WriteLine(contador); // agora vai soma  os valores a te chega em 10

                //pra quebra o loop temos que  temos que fazer a varivael somar

                // exemplo :
                
                //contador = contador + 1;
                
                //existem outras formas mais simples  doque essa

                //contador += 1;

                //uma das mais usadas e a :

                contador++;

            }

            Console.WriteLine("fim da contagem");

            // o Do while e outra forma de repetição que implementa o while
            // basicamente mesmo  que la  no while seja false  a condição o DO while vai executa o codigo uma vez
            // exemplo

            do
            {
                Console.WriteLine(contador + "do while");
            } while (200000 < 19);



            Console.ReadLine();
        }
    } // fim do progama
}
