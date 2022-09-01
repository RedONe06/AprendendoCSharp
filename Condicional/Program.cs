using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testando condicionais.");

        int idade = 20;
        int quantidadePessoas = 3;
        
        //Assim como no Java \n também funciona pra quebrar a linha
        if (idade >= 18)
        {
            Console.WriteLine("Você tem mais de 18 anos" +
                "\nSeja bem vindo!");
        }
        else
        {
            if (quantidadePessoas > 1)
            {
                Console.WriteLine("Está acompanhado, pode entrar");
            }
            else
            {
                Console.WriteLine("Infelizmente você não pode entrar :(");
            }
            
        }

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}
