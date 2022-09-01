using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 5 - Caracteres e Textos");

        // char armazena até 16 bits e não pode ser vazio
        char letra = 'a'; //para char usa-se ''
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        letra = (char)(86 + 1);
        Console.WriteLine(letra);

        string primeiraFrase = "Alura - Cursos de tecnologia ";
        Console.WriteLine(primeiraFrase + 2022);

        string vazia = "";
        Console.WriteLine(vazia);

        letra = ' '; //char espaço é aceitável
        
        // o @ faz com que pegue a identação do código junto com a mensagem;
        string cursos = @"Cursos disponíveis:
- Go 
- C# 
- Python 
- Java";
        
        Console.WriteLine(cursos);


        Console.WriteLine("Tecle para sair");
        Console.ReadLine();
    }
}
