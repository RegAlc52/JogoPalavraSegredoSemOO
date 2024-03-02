using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a palavra secreta: ");
        string palavraSecreta = Console.ReadLine().ToLower();

        int tentativasMaximas = 5;
        int tentativas = 0;

        Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
        Console.WriteLine("Tente adivinhar a palavra secreta.");

        while (tentativas < tentativasMaximas)
        {
            Console.Write("Digite o seu palpite: ");
            string palpite = Console.ReadLine().ToLower();

            tentativas++;

            if (palpite == palavraSecreta)
            {
                Console.WriteLine($"Parabéns! Você acertou a palavra secreta '{palavraSecreta}'.");
                return;
            }
            else
            {
                Console.WriteLine("Palavra incorreta. Tente novamente.");
            }
        }

        Console.WriteLine($"Suas {tentativasMaximas} tentativas acabaram. A palavra secreta era '{palavraSecreta}'.");
    }
}
// Fazer um codigo para que o usuario adivinhe
// Uma palavra secreta 
// terá 5 tentativas par adivinhar a palavra secreta = int
// aparecer em tela os campos 
// Digite a palavra secreta = String
// Digite palpite = String
//Informar se acertou a palavra secreta 
//Infomar se errou a palavra secreta, tentar novamente
//Se errar todas as 5 tentativas, informar que acabaram as tentativas = int
// Informar qual era a palavra secreta = String

