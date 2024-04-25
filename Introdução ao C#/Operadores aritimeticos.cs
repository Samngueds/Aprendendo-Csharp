

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
            int soma = 20 + 20;
            int mult = 10 * 90;
            int div = 90 / 10;

            Console.WriteLine(soma);
            Console.WriteLine(mult);
            Console.WriteLine(div);

            // divisao de numeros inteiros o resutado sempre vai ser inteiro

            //  int div = 5 / 2  2.5 = 2

            // pra resolver  isso  você tem q  adicona um numero decimal
            // e muda a variavel pra float

            //  float div = 5.0f / 2;

            // em C# a divisao e a multplicação
            // tem prioridade a cima da soma e a subitração

            //exemplo:


            var teste = 2 + 4 - 10 / 3 * 5;
            Console.WriteLine(teste);

            // o resultado seria esperado seria -5

            //mais deu -9

            //Divisão: Primeiro, resolvemos a divisão
            //Em seguida, multiplicamos so depois que
            //vem a Adição e a Subtração
            // mais e possivel muda assim  como na matemacita adicionado ()
            // ele vai resolver  oque tiver em () primerio

            // exemplo :

            teste = (2 + 4 - 10) / 3 * 5;

            

            Console.WriteLine(teste);

            //agora com isso o resutado vai ser o esperado





            Console.ReadLine();
        }

    } // fim do progama
}
