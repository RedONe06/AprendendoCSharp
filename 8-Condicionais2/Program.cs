using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7 - Condicionais");

        int idadeJoao = 16;
        int quantidadeDePessoas = 2;
        bool grupo = true;
        bool acompanhado = quantidadeDePessoas > 1;

        if (idadeJoao >= 18 && acompanhado)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        { 
            Console.WriteLine("Não pode entrar!");
        }

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}
