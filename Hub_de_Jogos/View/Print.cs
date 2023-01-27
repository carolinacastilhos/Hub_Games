using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hub_de_Jogos.View
{
    public class Print
    {
        public void CorAvisoNegativo(string texto)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(texto);
            Console.ResetColor();
        }

        public void CorAvisoPositivo(string texto)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(texto);
            Console.ResetColor();
        }

        public void InicioHub()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Bem-vindo(a) ao Hub de Jogos!\n");
            Console.ResetColor();
        }

        public void SaidaHub()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nEncerrando o Hub de Jogos... Muito obrigada por passar este tempo com nós!\n");
            Console.WriteLine("Volte sempre que quiser se divertir um pouco!");
            Console.ResetColor();
        }

        public void ApresentarMenuInicial()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n Menu Principal \n");
            Console.ResetColor();

            Console.WriteLine("\t1. Menu Jogadores");
            Console.WriteLine("\t2. Ranking de Jogadores");
            Console.WriteLine("\t3. Jogar Jogo da Velha");
            Console.WriteLine("\t4. Jogar Batalha Naval");
            Console.WriteLine("\t5. Sair do Jogo\n");

            Console.Write("Digite a opção desejada: ");
        }

        public void ApresentarMenuJogadores()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n Menu Jogadores \n");
            Console.ResetColor();

            Console.WriteLine("\t1. Cadastrar novo Jogador");
            Console.WriteLine("\t2. Deletar Jogador");
            Console.WriteLine("\t3. Detalhes Jogador");
            Console.WriteLine("\t4. Voltar ao Menu Principal\n");
            
            Console.Write("Digite a opção desejada: ");
        }

    }
}
