[![Typing SVG](https://readme-typing-svg.herokuapp.com?font=Oswald&weight=500&size=30&pause=1000&color=007ACC&width=435&lines=Seja+Bem+Vindo;Bora+Aprender+C%23)](https://git.io/typing-svg)

🔥<img align="margin-rigth: 100px;" src="https://media1.tenor.com/m/JNzoGnuhWKkAAAAC/elmo-fire.gif" width="50" height="50">🔥[![Typing SVG](https://readme-typing-svg.herokuapp.com?font=Oswald&weight=500&size=30&pause=1000&color=007ACC&center=true&vCenter=true&width=435&lines=Estruturas+de+Controle+)](https://git.io/typing-svg)🔥<img align="margin-left: 100px;" src="https://media1.tenor.com/m/JNzoGnuhWKkAAAAC/elmo-fire.gif" width="50" height="50">🔥

![csharp-gif](https://media1.tenor.com/m/cX92mi1p-NYAAAAd/coding-anime.gif)

Neste arquivo, discutiremos as estruturas de controle em C#, que permitem que você tome decisões no seu código com base em condições específicas.

## Exemplos

### 1. **Estrutura de Else if.cs**

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hellow_World
{
    class Program
    {
        static void Main(string[] args) // função principal, ela é executada primeiro
        {
            // Estrutura de if e else

            // Exemplo:
            int idade = 17;

            if (idade > 17) // se
            {
                Console.WriteLine("Você é maior de idade");
            }
            else if (idade == 17) // se não for mas...
            {
                Console.WriteLine("Sua idade é: " + idade);
            }
            else // se não
            {
                Console.WriteLine("Você é menor de idade");
            }

            Console.ReadLine();
        }
    } // fim do programa
}
```

#### O que é a estrutura de `if` e `else`?
- **`if`**: Avalia uma condição. Se a condição for verdadeira, o bloco de código dentro do `if` é executado.
- **`else if`**: Permite testar uma nova condição se a condição anterior for falsa.
- **`else`**: Executa um bloco de código quando todas as condições anteriores são falsas.

### 2. **If & else básico.cs**

```csharp
using System;

namespace Hellow_World
{
    class Program
    {
        static void Main(string[] args) // função principal, ela é executada primeiro
        {
            // Estrutura de if e else

            // Exemplo:
            int idade = 0;

            if (idade >= 18) // se
            {
                Console.WriteLine("Você é maior de idade");
            }
            else // se não
            {
                Console.WriteLine("Você é menor de idade");
            }

            Console.ReadLine();
        }
    } // fim do programa
}
```

#### Como funciona a estrutura básica de `if` e `else`?
- Neste exemplo, se a variável `idade` for maior ou igual a 18, a mensagem correspondente é exibida; caso contrário, uma mensagem diferente é mostrada.

### 3. **Operadores lógicos com IF e Else Parte 1.cs**

```csharp
using System;

namespace Hellow_World
{
    class Program
    {
        static void Main(string[] args) // função principal, ela é executada primeiro
        {
            // Operadores lógicos para if e else

            // && (E ou AND) e ||(OU/OR)

            // Exemplo de AND/&& :
            int idade = 18;
            string CNH = "não";

            if (idade > 17 && CNH == "tem") // se
            {
                Console.WriteLine("Você está apto a dirigir");
            }
            else if (idade == 18 && CNH != "tem") // se não for mas...
            {
                Console.WriteLine("Sua idade é: " + idade + " Lhe falta a CNH. Você não está apto a dirigir");
            }
            else // se não
            {
                Console.WriteLine("Você não está apto. Lhe falta a CNH e ser maior de idade");
            }

            Console.ReadLine();
        }
    } // fim do programa
}
```

#### O que são operadores lógicos?
- **Operador AND (`&&`)**: Retorna `true` se ambas as condições forem verdadeiras.
- **Operador OR (`||`)**: Retorna `true` se pelo menos uma das condições for verdadeira.

### 4. **Operadores lógicos com IF e Else Parte 2.cs**

```csharp
using System;

namespace Hellow_World
{
    class Program
    {
        static void Main(string[] args) // função principal, ela é executada primeiro
        {
            // Exemplo de AND/&& usando entrada de dados do usuário

            int idade = 0;
            string CNH = "";

            Console.WriteLine("Por favor, digite sua idade:");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Você tem carteira de motorista? (sim/não)");
            CNH = Console.ReadLine();

            if (idade > 17 && CNH == "sim") // se
            {
                Console.WriteLine("Você está apto a dirigir");
            }
            else if (idade == 18 && CNH != "sim") // se não for mas...
            {
                Console.WriteLine("Sua idade é: " + idade + " Lhe falta a CNH. Você não está apto a dirigir");
            }
            else // se não
            {
                Console.WriteLine("Você não está apto. Lhe falta a CNH e ser maior de idade");
            }

            Console.ReadLine();
        }
    } // fim do programa
}
```

#### Como usar operadores lógicos com entrada de dados?
- A estrutura `if` é usada para verificar a idade do usuário e se ele possui carteira de motorista. O resultado varia de acordo com as entradas fornecidas.

---

## Conclusão

As estruturas de controle são fundamentais para a lógica de programação. Elas permitem que você tome decisões baseadas em condições, facilitando o controle do fluxo do seu programa.

Para mais informações, você pode acessar o [Curso de C# da Microsoft com certificação](https://learn.microsoft.com/pt-br/training/paths/get-started-c-sharp-part-1/).

## 🤝 Contribuições

Contribuições são bem-vindas! Se você tem sugestões de melhorias ou novos exemplos, sinta-se à vontade para abrir uma *pull request*.