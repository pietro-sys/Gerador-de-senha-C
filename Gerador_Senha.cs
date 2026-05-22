using System;

class Gerador_Senha
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Gostaria de gerar uma senha? (s/n)");
            string resposta = Console.ReadLine().Trim();

            if (resposta == "n")
            {
                Console.WriteLine("Saindo do programa. Até mais!");
                break;
            }
            else if (resposta == "s")
            {
                while (true)
                {
                    try
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
                        Console.WriteLine("\nDeseja gerar outra senha? (s/n)");
                        string continuar = Console.ReadLine().Trim();
                        if (continuar == "n")
                        {
                            Console.WriteLine("Saindo do programa. Até mais!");
                            Environment.Exit(0);
                        }
                        if (continuar == "s")
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida. Saindo do programa.");
                            Environment.Exit(0);
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Opção inválida. Digite 's' ou 'n'.");
                Console.ReadKey(true);
            }
        }
    }
}