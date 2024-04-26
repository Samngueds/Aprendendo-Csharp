

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
            geravalor(12, "refrigerante");



            Console.ReadLine();
        }

        //  pra cria uma  função se usa  statick
        //  E preciso defini um retorno
        //  que  no caso seria  nada = void


        static  void exibirmsg()
        {
            Console.WriteLine("teste");
        }


        // pode funções receber parametros e  os parametro so podem  ser usado naquela  função

        static void geravalor( float valor, string nome)
        {
            Console.WriteLine("nome do produto: " + nome);
            Console.WriteLine("valor do produto: " + "R$"+valor);


        }




    } // fim do progama
}
