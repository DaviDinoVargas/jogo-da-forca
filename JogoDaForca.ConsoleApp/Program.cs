using System;

namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                JogoDaForca.IniciarNovoJogo();

                do
                {
                    Console.Clear();
                    DesenharForca();
                    ProcessarEntradaUsuario();
                    VerificarFimDeJogo();

                } while (!JogoDaForca.jogadorGanhou && !JogoDaForca.jogadorPerdeu);

                if (!DesejaContinuar())
                    break;
            }

            Console.WriteLine("Finalizando...");
            Console.ReadLine();
        }
        static void DesenharForca()
        {

            string cabecaDesenho = JogoDaForca.quantidadeErros >= 1 ? "X_x " : " ";
            string troncoDesenho = JogoDaForca.quantidadeErros >= 2 ? "|" : " ";
            string troncoInferiorDesenho = JogoDaForca.quantidadeErros >= 2 ? " | " : " ";
            string braco1Desenho = JogoDaForca.quantidadeErros >= 3 ? "/" : " ";
            string braco2Desenho = JogoDaForca.quantidadeErros >= 4 ? "\\" : " ";
            string pernasDesenho = JogoDaForca.quantidadeErros >= 5 ? "/ \\" : " ";

            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("             Jogo da Forca");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(" ___________        ");
            Console.WriteLine(" |/        |        ");
            Console.WriteLine(" |        {0}       ", cabecaDesenho);
            Console.WriteLine(" |                  ");
            Console.WriteLine(" |        {0}{1}{2} ", braco1Desenho, troncoDesenho, braco2Desenho);
            Console.WriteLine(" |        {0}       ", troncoInferiorDesenho);
            Console.WriteLine(" |        {0}       ", pernasDesenho);
            Console.WriteLine(" |                  ");
            Console.WriteLine(" |                  ");
            Console.WriteLine("_|____    " + String.Join("", JogoDaForca.letrasEncontradas));
            Console.WriteLine("ERROS: " + JogoDaForca.quantidadeErros);
            Console.WriteLine("-----------------------------------------");
        }

        //dado um caractere
        static void ProcessarEntradaUsuario()
        {
            Console.Write("Digite uma letra válida: ");
            string entradaInicial = Console.ReadLine()!.ToUpper();

            if (entradaInicial.Length > 1)
            {
                Console.WriteLine("Entrada inválida! Digite apenas uma letra. Pressione Enter para tentar novamente.");
                Console.ReadLine();
                Console.ReadLine();
                return;
            }

            JogoDaForca.VerificarLetra(entradaInicial[0]);
        }
            static void VerificarFimDeJogo()
            {
                if (JogoDaForca.jogadorGanhou)
                {
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine($"Você acertou a palavra {JogoDaForca.palavraEscolhida}, parabéns!");
                    Console.WriteLine("----------------------------------------");
                }
                else if (JogoDaForca.jogadorPerdeu)
                {
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine($"Você perdeu, atingiu {JogoDaForca.quantidadeErros} erros, a palavra era: {JogoDaForca.palavraEscolhida}");
                    Console.WriteLine("----------------------------------------");
                }
            }
        public static bool DesejaContinuar()
        {
            Console.Write("Deseja jogar novamente? (S/N)");
            return Console.ReadLine()!.ToUpper() == "S";
        }
    }  
    }