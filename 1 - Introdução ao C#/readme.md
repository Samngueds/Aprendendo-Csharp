[![Typing SVG](https://readme-typing-svg.herokuapp.com?font=Oswald&weight=500&size=30&pause=1000&color=007ACC&width=435&lines=Seja+Bem+Vindo;Bora+Aprender+C%23)](https://git.io/typing-svg)

🔥<img align="margin-rigth: 100px;" src="https://media1.tenor.com/m/JNzoGnuhWKkAAAAC/elmo-fire.gif" width="50" height="50">🔥[![Typing SVG](https://readme-typing-svg.herokuapp.com?font=Oswald&weight=500&size=30&pause=1000&color=007ACC&center=true&vCenter=true&width=435&lines=Introdução+ao+C%23+)](https://git.io/typing-svg)🔥<img align="margin-left: 100px;" src="https://media1.tenor.com/m/JNzoGnuhWKkAAAAC/elmo-fire.gif" width="50" height="50">🔥

![csharp-gif](https://media1.tenor.com/m/cX92mi1p-NYAAAAd/coding-anime.gif)

Neste arquivo, abordaremos conceitos fundamentais de C# para iniciantes. Os exemplos apresentados servem como uma base sólida para o entendimento da linguagem e suas aplicações.

## Exemplos

### 1. **Console.Write_e_derivados.cs**

```csharp
using System;

namespace Hellow_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("hello world"); // Exibe a mensagem "hello world" no console
            Console.WriteLine(""); // Adiciona uma linha em branco

            Console.ReadLine(); // Aguarda a entrada do usuário e mantém o console aberto
        }
    }
}
```

#### O que isso faz?
- **`using System;`**: Importa o namespace System, que contém classes fundamentais para a execução de operações básicas, como entrada e saída.
- **Classes**: Um bloco de código que define um tipo de objeto, onde podem ser agrupadas variáveis e métodos relacionados.
- **Variáveis**: Contêineres que armazenam dados. No exemplo, não são usadas variáveis, mas normalmente você declararia algo como `int x = 5;`.
- **Funções**: Blocos de código que realizam uma tarefa específica. No exemplo, `Main` é a função de entrada que é executada ao iniciar o programa.

### 2. **Operadores Aritméticos.cs**

```csharp
using System;

namespace Hellow_World
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 20 + 20;
            int mult = 10 * 90;
            int div = 90 / 10;

            Console.WriteLine(soma);
            Console.WriteLine(mult);
            Console.WriteLine(div);

            var teste = 2 + 4 - 10 / 3 * 5;
            Console.WriteLine(teste);

            teste = (2 + 4 - 10) / 3 * 5;
            Console.WriteLine(teste);

            Console.ReadLine();
        }
    }
}
```

#### O que são Operadores Aritméticos?
- **Operadores Aritméticos**: Símbolos que executam operações em variáveis e valores. Os principais são:
  - **`+`**: Adição
  - **`-`**: Subtração
  - **`*`**: Multiplicação
  - **`/`**: Divisão
- **Precedência de Operadores**: Em C#, a multiplicação e a divisão têm precedência sobre a adição e a subtração. Use parênteses `()` para alterar a ordem das operações, se necessário.

### 3. **Outros Tipos de Definições de Variáveis.cs**

```csharp
using System;

namespace Hellow_World
{
    class Program
    {
        static void Main(string[] args)
        {
            var cor_favorita = "azul";
            dynamic cor_favorita2 = "vermelho";
            Console.WriteLine(cor_favorita2);

            cor_favorita2 = 01010100101;
            Console.WriteLine(cor_favorita2);

            Console.ReadLine();
        }
    }
}
```

#### O que é a diferença entre `var` e `dynamic`?
- **`var`**: Permite que você declare uma variável sem especificar seu tipo explicitamente. O tipo é inferido pelo compilador no momento da atribuição. Por exemplo, `var numero = 10;` resulta em um tipo `int`.
- **`dynamic`**: Permite a mudança do tipo de uma variável em tempo de execução. Isso pode ser útil, mas deve ser usado com cuidado, pois pode levar a erros em tempo de execução. Por exemplo, `dynamic valor = "texto";` e depois `valor = 100;` é perfeitamente válido.

### 4. **Tipo de Dados & Definições de Variáveis.cs**

```csharp
using System;

namespace Hellow_World
{
    class Program
    {
        static void Main(string[] args)
        {
            int segunda_guerra_mundial = 1942;
            string cor_favorita = "azul";
            float peso = 56.5f;
            bool segunda_guerra_mundial_Aconteceu = true;

            Console.WriteLine(segunda_guerra_mundial);
            Console.WriteLine(cor_favorita);
            Console.WriteLine(segunda_guerra_mundial_Aconteceu);
            Console.WriteLine(peso);

            cor_favorita = "roxo";
            Console.WriteLine(cor_favorita);

            Console.ReadLine();
        }
    }
}
```

#### Como escolher o tipo de variável?
- **Tipos de Variáveis**: Escolha um tipo que corresponda aos dados que você precisa armazenar:
  - **`int`**: Para números inteiros (ex: `int idade = 30;`).
  - **`float`**: Para números decimais (ex: `float altura = 1.75f;`).
  - **`bool`**: Para valores booleanos (true/false).
  - **`string`**: Para texto (ex: `string nome = "Maria";`).
  - **`char`**: Para um único caractere (ex: `char letra = 'A';`).

### 5. **Constantes.cs**

```csharp
using System;

namespace Hellow_World
{
    class Program
    {
        static void Main(string[] args)
        {
            const float PI = 3.1455555565f;
            Console.ReadLine();
        }
    }
}
```

#### O que são constantes e como usá-las?
- **Constantes**: Variáveis cujo valor não pode ser alterado após a inicialização. São úteis para valores fixos, como taxas de impostos ou constantes matemáticas. Para declarar uma constante, utiliza-se a palavra-chave `const`, como no exemplo `const float PI = 3.14f;`.

### 6. **Sistema de Input.cs**

```csharp
using System;

namespace Hellow_World
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            Console.WriteLine("Escreva seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("seu nome e :");
            Console.WriteLine(nome);

            Console.ReadLine();
        }
    }
}
```

#### Como o sistema de entrada funciona em C#?
- **Sistema de Input**: Permite que o usuário insira dados durante a execução do programa. O `Console.ReadLine()` lê a entrada do usuário e a armazena na variável especificada. Isso é fundamental para interações dinâmicas em programas, permitindo que os usuários personalizem sua experiência.

---

## Conclusão

Esses exemplos fornecem uma base sólida para começar a programar em C#. Compreender os conceitos de operadores, variáveis, constantes e entrada de dados é essencial para avançar em seu aprendizado. Sinta-se à vontade para experimentar e modificar os exemplos apresentados para aprofundar sua compreensão da linguagem.

Para mais informações, você pode acessar o [Curso de C# da Microsoft com certificação](https://learn.microsoft.com/pt-br/training/paths/get-started-c-sharp-part-1/).

## 🤝 Contribuições

Contribuições são bem-vindas! Se você tem sugestões de melhorias ou novos exemplos, sinta-se à vontade para abrir uma *pull request*.
