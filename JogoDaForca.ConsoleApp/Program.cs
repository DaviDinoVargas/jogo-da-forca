using System;

namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool jogarNovamente = true;
            while(jogarNovamente)
            { 
                string[] palavras = {
                    "TYRANNOSAURUS-REX",
                    "TRICERATOPS",
                    "VELOCIRAPTOR",
                    "BRACHIOSAURUS",
                    "STEGOSAURUS",
                    "ANKYLOSAURUS",
                    "SPINOSAURUS",
                    "ALLOSAURUS",
                    "DIPLODOCUS",
                    "PARASAUROLOPHUS",
                    "IGUANODON",
                    "CARNOTAURUS",
                    "CORYTHOSAURUS",
                    "GIGANOTOSAURUS",
                    "DEINONYCHUS",
                    "EDMONTOSAURUS",
                    "GALLIMIMUS",
                    "SAUROLOPHUS",
                    "PACHYCEPHALOSAURUS",
                    "THERIZINOSAURUS",
                    "STYRACOSAURUS",
                    "ALBERTOSAURUS",
                    "EORAPTOR",
                    "CHASMOSAURUS",
                    "KENTROSAURUS",
                    "HYPSILOPHODON",
                    "MAIASAURA",
                    "MOROS-INTREPIDUS",
                    "RUGOPS",
                    "MICROCERATUS"
                                };

                Random geradorDeNumeros = new Random();
                int indiceEscolhido = geradorDeNumeros.Next(palavras.Length);
                string palavraEscolhida = palavras[indiceEscolhido];
                

                //[null, null, null, null...]
                char[]letrasEncontradas = new char[palavraEscolhida.Length];
                for (int caractereAtual = 0; caractereAtual < letrasEncontradas.Length; caractereAtual++)
                {
                    letrasEncontradas[caractereAtual] = '_';
                }
                int quantidadeErros = 0;
                bool jogadorPerdeu = false;
                bool jogadorGanhou = false;

                 do // faça
                {
                

                string cabecaDesenho = quantidadeErros >= 1 ? "X_x " : " ";
                string troncoDesenho = quantidadeErros >= 2 ? "|" : " ";
                string troncoInferiorDesenho = quantidadeErros >= 2 ? " | " : " ";
                string braco1Desenho = quantidadeErros >= 3 ? "/" : " ";
                string braco2Desenho = quantidadeErros >= 4 ? "\\" : " ";
                string pernasDesenho = quantidadeErros >= 5 ? "/ \\" : " ";

                   
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
                Console.WriteLine("_|____    " + String.Join("",letrasEncontradas));
                Console.WriteLine("ERROS: " + quantidadeErros);
                Console.WriteLine("----------------------------------------");


                    //dado um caractere

                    Console.Write("Digite uma letra válida: ");
                    string entradaInicial = Console.ReadLine()!.ToUpper();

                    if (entradaInicial.Length > 1)
                    {
                        Console.WriteLine("Entrada inválida! Digite apenas uma letra. Pressione Enter para tentar novamente.");
                        Console.ReadLine();
                        continue;
                    }

                    bool letraFoiEncontrada = false;
                    char chute = entradaInicial[0];
                    for (int contadorCaracteres = 0; contadorCaracteres < palavraEscolhida.Length; contadorCaracteres++)
                {
                        
                        char caractereAtual = palavraEscolhida[contadorCaracteres];

                    if (chute == caractereAtual)
                    {
                        letrasEncontradas[contadorCaracteres] = caractereAtual;
                        letraFoiEncontrada = true;
                    }
                }
                    if (letraFoiEncontrada == false)
                        quantidadeErros++;


                    string palavraEncontradaCompleta = String.Join("",letrasEncontradas);

                    jogadorGanhou = palavraEncontradaCompleta == palavraEscolhida;
                    jogadorPerdeu = quantidadeErros > 5;

                    if (jogadorGanhou)
                {
                    
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine($"Você acertou a palavra {palavraEscolhida}, parabéns!");
                    Console.WriteLine("----------------------------------------");
                }


                else if (jogadorPerdeu)
                {
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine($"Você perdeu, atingiu os {quantidadeErros} erros, a palavra era: {palavraEscolhida}");
                    Console.WriteLine("----------------------------------------");
                }

                } while (jogadorGanhou == false && jogadorPerdeu == false); // enquanto (condição)


                Console.Write("Deseja jogar novamente? (S/N)");
                string resposta = Console.ReadLine()!.ToUpper().Trim();
                if (resposta != "S")
                {
                    jogarNovamente = false;
                }

                Console.Clear();
            }
            Console.WriteLine("Finalizando...");
            Console.ReadLine();
        }
    }
}