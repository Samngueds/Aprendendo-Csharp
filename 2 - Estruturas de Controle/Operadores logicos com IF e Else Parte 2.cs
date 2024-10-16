

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

            //Operadores Logicos pra If e else


            //Exemplo de AND/&& Usando Entrada de dados do usuario


            

            int idade = 0;
            String CNH = "";



            Console.WriteLine("Por favor Digite Se VocÊ trouxe o Alimento e brinquedo");

            Console.WriteLine("Qual a sua idade?");
            //parse Converte strings em numeros inteiros ou não
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Você tem carteira de motorista?");
            CNH = Console.ReadLine();




            if (idade > 17 && CNH =="sim") // se
            {
                Console.WriteLine("você esta apto a dirigir");
            }
            else if (idade == 18 && CNH != "sim") // se nao for mas..
            {
                Console.WriteLine("sua idaide e: " + idade + " Lhe falta a CNH " + "Você não esta apto a digir");
            }
            else // se não
            {
                Console.WriteLine("Você Não Esta Apto " + "lhe falta a CNH e ser Maior de idade");
            }




            //Exemplo de ||/OR Usando Entrada de dados do usuario

            string Alimento = "";
            String brinquedo = "";



            Console.WriteLine("Por favor Digite sua idade e se você tem Carteira de motorista");

            Console.WriteLine("Você tem o Alimento?");
            //parse Converte strings em numeros inteiros ou não
            Alimento = Console.ReadLine();
            Console.WriteLine("Você tem o brinquedo?");
            brinquedo = Console.ReadLine();




            if (Alimento == "Sim" || brinquedo == "Sim") // se
            {
                Console.WriteLine("Você tem oque e necessario pra entra");
            }
            else if (Alimento == "Sim" || brinquedo != "Sim") // se nao for mas..
            {
                Console.WriteLine("Você tem tem o alimento mas não tem o Brinquedo pode entra");
            }
            else if (Alimento != "Sim" || brinquedo == "Sim") // se nao for mas..
            {
                Console.WriteLine("Você tem tem o Brinquedo mas não tem o alimento pode entra");
            }
            else // se não
            {
                Console.WriteLine("Você Não Esta Apto a entra não tem nem o a limento nem o brinquedo");
            }




            Console.ReadLine();
        }

    } // fim do progama
}
