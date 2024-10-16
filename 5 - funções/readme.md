[![Typing SVG](https://readme-typing-svg.herokuapp.com?font=Oswald&weight=500&size=30&pause=1000&color=007ACC&width=435&lines=Seja+Bem+Vindo;Bora+Aprender+C%23)](https://git.io/typing-svg)

🔥<img align="margin-right: 100px;" src="https://media1.tenor.com/m/JNzoGnuhWKkAAAAC/elmo-fire.gif" width="50" height="50">🔥[![Typing SVG](https://readme-typing-svg.herokuapp.com?font=Oswald&weight=500&size=30&pause=1000&color=007ACC&center=true&vCenter=true&width=435&lines=Funções+em+C%23)](https://git.io/typing-svg)🔥<img align="margin-left: 100px;" src="https://media1.tenor.com/m/JNzoGnuhWKkAAAAC/elmo-fire.gif" width="50" height="50">🔥

![csharp-gif](https://media1.tenor.com/m/cX92mi1p-NYAAAAd/coding-anime.gif)

Nesta seção, exploramos o conceito de **funções** em C#. Vamos aprender a declarar funções, como passar parâmetros e como lidar com valores de retorno.

## Exemplos

### 1. **Funções com Retorno de Valores**

```csharp
using System;

namespace Hellow_World
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chamando uma função com parâmetros
            geravalor(12, "refrigerante");

            // Usando uma função que retorna um valor
            int soma1 = somar(20, 32, 34);
            Console.WriteLine(soma1); // Exibe 86

            Console.ReadLine();
        }

        // Função que não retorna valor (void) e exibe uma mensagem
        static void exibirmsg()
        {
            Console.WriteLine("Teste");
        }

        // Função que recebe parâmetros e exibe informações
        static void geravalor(float valor, string nome)
        {
            Console.WriteLine("Nome do produto: " + nome);
            Console.WriteLine("Valor do produto: R$" + valor);
        }

        // Função que retorna a soma de três números
        static int somar(int a, int b, int c)
        {
            int resultado_final = a + b + c;
            return resultado_final;
        }
    }
}
```

#### O que é uma função?
- **Função**: Bloco de código reutilizável que realiza uma tarefa específica. Pode ou não retornar um valor.
- **Parâmetros**: Variáveis que são passadas para a função quando ela é chamada.
- **Retorno de valor**: Algumas funções retornam valores ao código que as chamou. O tipo do valor retornado é definido na assinatura da função.

### 2. **Funções Estrutura & Parâmetros**

```csharp
using System;

namespace Hellow_World
{
    class Program
    {
        static void Main(string[] args)
        {
            // Função chamada com dois parâmetros
            geravalor(12, "refrigerante");
            Console.ReadLine();
        }

        // Função sem retorno que exibe uma mensagem
        static void exibirmsg()
        {
            Console.WriteLine("Teste");
        }

        // Função que recebe parâmetros e exibe informações
        static void geravalor(float valor, string nome)
        {
            Console.WriteLine("Nome do produto: " + nome);
            Console.WriteLine("Valor do produto: R$" + valor);
        }
    }
}
```

#### O que são parâmetros?
- **Parâmetros**: Valores que uma função recebe quando é chamada. Eles podem ser de diferentes tipos (inteiros, strings, floats etc.), e só podem ser usados dentro da função.

---

## Conclusão

As funções são fundamentais em C# para organizar e reutilizar blocos de código. Elas podem retornar valores, receber parâmetros e realizar diversas operações que facilitam o desenvolvimento de programas eficientes e estruturados.
