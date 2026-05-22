using System;

class Gerador_Senha
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Gerador de Senha");
        Console.WriteLine("Digite o comprimento da senha:");
        int comprimento = int.Parse(Console.ReadLine());

        string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()";
        Random random = new Random();
        string senha = "";

        for (int i = 0; i < comprimento; i++)
        {
            int index = random.Next(caracteres.Length);
            senha += caracteres[index];
        }

        Console.WriteLine("Senha gerada: " + senha);
    }
}