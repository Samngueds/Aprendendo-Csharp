[![Typing SVG](https://readme-typing-svg.herokuapp.com?font=Oswald&weight=500&size=30&pause=1000&color=007ACC&width=435&lines=Seja+Bem+Vindo;Bora+Aprender+C%23)](https://git.io/typing-svg)

🔥<img align="margin-rigth: 100px;" src="https://media1.tenor.com/m/JNzoGnuhWKkAAAAC/elmo-fire.gif" width="50" height="50">🔥[![Typing SVG](https://readme-typing-svg.herokuapp.com?font=Oswald&weight=500&size=30&pause=1000&color=007ACC&center=true&vCenter=true&width=435&lines=Arrays+e+Coleções+em+C%23)](https://git.io/typing-svg)🔥<img align="margin-left: 100px;" src="https://media1.tenor.com/m/JNzoGnuhWKkAAAAC/elmo-fire.gif" width="50" height="50">🔥

![csharp-gif](https://media1.tenor.com/m/cX92mi1p-NYAAAAd/coding-anime.gif)

Neste arquivo, aprenderemos sobre arrays e coleções, elementos essenciais em C# para o armazenamento e manipulação de dados. Veremos exemplos práticos de arrays, enums e a combinação de enums com estruturas de controle como switch.

## Exemplos

### 1. **Array.cs**

```csharp
using System;

namespace Hellow_World
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays são semelhantes a variáveis, mas podem armazenar múltiplos valores de um mesmo tipo.

            string[] Abc = new string[] { "a", "b", "c", "d", "e", "f" };

            // Acessar um valor do array usando o índice:
            Console.WriteLine(Abc[0]); // Exibe "a"

            Console.ReadLine();
        }
    }
}
```

#### O que é um array?
- **Array**: Uma estrutura que armazena múltiplos valores do mesmo tipo em uma sequência.
- **Acesso por índice**: Cada elemento é acessado por um índice numérico, começando em 0.

### 2. **Enum.cs**

```csharp
using System;

namespace Hellow_World
{
    class Program
    {
        enum cor { azul, verde, rosa, vermelho }

        static void Main(string[] args)
        {
            cor corfavorita = cor.azul;
            Console.WriteLine(corfavorita); // Exibe "azul"

            // Converter enum para número:
            Console.WriteLine((cor)2); // Exibe "rosa"

            Console.ReadLine();
        }
    }
}
```

#### O que é um enum?
- **Enum**: Um tipo especial que permite definir um conjunto de constantes nomeadas. Os valores são automaticamente indexados.
- **Conversão para número**: É possível converter valores de enum para seu índice numérico.

### 3. **Switch.cs**

```csharp
using System;

namespace Hellow_World
{
    class Program
    {
        static void Main(string[] args)
        {
            string cor = "azul";

            switch(cor)
            {
                case "vermelho":
                    Console.WriteLine("Sua cor favorita é vermelho");
                    break;
                case "azul":
                    Console.WriteLine("Sua cor favorita é Azul");
                    break;
                default:
                    Console.WriteLine("Cor desconhecida");
                    break;
            }

            Console.ReadLine();
        }
    }
}
```

#### O que é switch?
- **Switch**: Uma estrutura de controle que verifica um valor e executa o código correspondente a esse valor.
- **Caso padrão**: O `default` é executado se nenhum dos outros casos for verdadeiro.

### 4. **Enum + Switch.cs**

```csharp
using System;

namespace Hellow_World
{
    class Program
    {
        enum cor { azul = 1, verde, rosa, vermelho }

        static void Main(string[] args)
        {
            Console.WriteLine("Escolha sua cor favorita (1- Azul, 2- Verde, 3- Rosa, 4- Vermelho):");
            int index = int.Parse(Console.ReadLine());
            cor option = (cor)index;

            switch (option)
            {
                case cor.vermelho:
                    Console.WriteLine("Sua cor favorita é vermelho");
                    break;
                case cor.azul:
                    Console.WriteLine("Sua cor favorita é Azul");
                    break;
                case cor.rosa:
                    Console.WriteLine("Sua cor favorita é rosa");
                    break;
                case cor.verde:
                    Console.WriteLine("Sua cor favorita é verde");
                    break;
                default:
                    Console.WriteLine("Escolha uma cor válida.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
```

#### O que combina enum e switch?
- **Enum e Switch**: Combinação poderosa para menus baseados em opções fixas.
- **Conversão de entrada**: A entrada do usuário é convertida para o tipo enum e usada no switch para exibir a escolha correspondente.

---

## Conclusão

Os arrays e enums são formas fundamentais de armazenar e organizar dados em C#. A capacidade de usar enums em conjunto com switch simplifica a criação de menus e outras estruturas controladas por opções.
