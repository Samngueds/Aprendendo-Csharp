[![Typing SVG](https://readme-typing-svg.herokuapp.com?font=Oswald&weight=500&size=30&pause=1000&color=007ACC&width=435&lines=Seja+Bem+Vindo;Bora+Aprender+C%23)](https://git.io/typing-svg)

🔥<img align="margin-rigth: 100px;" src="https://media1.tenor.com/m/JNzoGnuhWKkAAAAC/elmo-fire.gif" width="50" height="50">🔥[![Typing SVG](https://readme-typing-svg.herokuapp.com?font=Oswald&weight=500&size=30&pause=1000&color=007ACC&center=true&vCenter=true&width=435&lines=Estruturas+de+Repetição+em+C%23+)](https://git.io/typing-svg)🔥<img align="margin-left: 100px;" src="https://media1.tenor.com/m/JNzoGnuhWKkAAAAC/elmo-fire.gif" width="50" height="50">🔥

![csharp-gif](https://media1.tenor.com/m/cX92mi1p-NYAAAAd/coding-anime.gif)

Neste arquivo, abordaremos as estruturas de repetição em C#. Elas são fundamentais para a execução de um bloco de código várias vezes, facilitando a automação de tarefas e o processamento de dados.

## Exemplos

### 1. **do while.cs**

```csharp
using System;

namespace Hellow_World
{
    class Program
    {
        static void Main(string[] args) // função principal, ela é executada primeiro
        {
            int contador = 0; // aqui o contador está definido como 0

            while (contador < 10)
            {
                Console.WriteLine(contador + 1); // assim visualmente ele vai contar a partir do um
                contador++; // incrementa o contador
            }

            Console.WriteLine("fim da contagem");

            // do while: executa o código pelo menos uma vez
            do
            {
                Console.WriteLine(contador + " do while");
            } while (200000 < 19);

            Console.ReadLine();
        }
    } // fim do programa
}
```

#### O que isso faz?
- **`while`**: Repete o bloco de código enquanto a condição for verdadeira. Aqui, o loop continua enquanto `contador` for menor que 10.
- **`do while`**: Garante que o código dentro dele será executado pelo menos uma vez, mesmo que a condição seja falsa. 

### 2. **for.cs**

```csharp
using System;

namespace Hellow_World
{
    class Program
    {
        static void Main(string[] args) // função principal, ela é executada primeiro
        {
            string[] palavras = { "pc", "refri", "soverte", "livro", "dinosauro" };

            for (int contador = 0; contador < palavras.Length; contador++) // percorre o array
            {
                Console.WriteLine(contador + 1);
                Console.WriteLine(palavras[contador]); // imprime a palavra correspondente
            }

            Console.WriteLine("====================================");

            for (int contador2 = palavras.Length - 1; contador2 >= 0; contador2--) // percorre o array ao contrário
            {
                Console.WriteLine(contador2 + 1);
                Console.WriteLine(palavras[contador2]);
            }

            Console.WriteLine("fim da função");
            Console.ReadLine();
        }
    } // fim do programa
}
```

#### O que isso faz?
- **`for`**: Um loop que combina a inicialização, condição e incremento em uma única linha. Ele é útil para iterar sobre arrays ou coleções.
- **`palavras.Length`**: Retorna o número de elementos no array.

### 3. **foreach.cs**

```csharp
using System;

namespace Hellow_World
{
    class Program
    {
        static void Main(string[] args) // função principal, ela é executada primeiro
        {
            string[] palavras = { "livro", "pc", "bancada", "jogos", "notebook" };

            foreach (string palavra in palavras) // percorre cada palavra no array
            {
                Console.WriteLine(palavra);
            }

            Console.WriteLine("fim da função");
            Console.ReadLine();
        }
    } // fim do programa
}
```

#### O que isso faz?
- **`foreach`**: Um loop projetado para iterar sobre coleções e arrays de maneira simplificada, sem a necessidade de gerenciar um índice manualmente.

### 4. **while.cs**

```csharp
using System;

namespace Hellow_World
{
    class Program
    {
        static void Main(string[] args) // função principal, ela é executada primeiro
        {
            int contador = 0; // aqui o contador está definido como 0

            while (contador < 10)
            {
                Console.WriteLine(contador + 1); // imprime o contador incrementado
                contador++; // incrementa o contador
            }

            Console.ReadLine();
        }
    } // fim do programa
}
```

#### O que isso faz?
- **`while`**: Executa o bloco de código enquanto a condição for verdadeira. Aqui, ele continua enquanto `contador` for menor que 10.

---

## Conclusão

Esses exemplos de estruturas de repetição fornecem uma base sólida para você compreender como automatizar tarefas e manipular coleções em C#. Compreender essas estruturas é essencial para o desenvolvimento de algoritmos eficientes. Sinta-se à vontade para experimentar e modificar os exemplos apresentados para aprofundar sua compreensão da linguagem.

Para mais informações, você pode acessar o [Curso de C# da Microsoft com certificação](https://learn.microsoft.com/pt-br/training/paths/get-started-c-sharp-part-1/).

## 🤝 Contribuições

Contribuições são bem-vindas! Se você tem sugestões de melhorias ou novos exemplos, sinta-se à vontade para abrir uma *pull request*.
