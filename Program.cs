using System;

namespace NomeSenha
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Clear();

            Console.WriteLine("--- Fazer Login ---");

                 string resposta;
                 string senha;

            do{
                 Console.Write("Digite seu username: ");
                 resposta = Console.ReadLine();

                 Console.Write("Digite sua senha: ");
                 senha = Console.ReadLine();

                 if(resposta == senha){
                 Console.ForegroundColor = ConsoleColor.Red;
                 Console.WriteLine("Erro!\r\nO username e a senha não podem ser iguais.");
                 Console.ResetColor();

                 }
            
            }while(resposta == senha);
            Console.ForegroundColor = ConsoleColor. Blue;   
            Console.WriteLine("Login realizado com sucesso!"); 
        }
    }
}
