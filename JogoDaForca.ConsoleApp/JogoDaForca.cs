using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace JogoDaForca.ConsoleApp
{
    public static class JogoDaForca
    {
        public static char[] letrasEncontradas;
        public static string palavraEscolhida;
        public static int quantidadeErros;
        public static bool jogadorPerdeu;
        public static bool jogadorGanhou;

        private static string[] palavras = {
            "TYRANNOSAURUS-REX", "TRICERATOPS", "VELOCIRAPTOR", "BRACHIOSAURUS",
            "STEGOSAURUS", "ANKYLOSAURUS", "SPINOSAURUS", "ALLOSAURUS", "DIPLODOCUS",
            "PARASAUROLOPHUS", "IGUANODON", "CARNOTAURUS", "CORYTHOSAURUS", "GIGANOTOSAURUS",
            "DEINONYCHUS", "EDMONTOSAURUS", "GALLIMIMUS", "SAUROLOPHUS", "PACHYCEPHALOSAURUS",
            "THERIZINOSAURUS", "STYRACOSAURUS", "ALBERTOSAURUS", "EORAPTOR", "CHASMOSAURUS",
            "KENTROSAURUS", "HYPSILOPHODON", "MAIASAURA", "MOROS-INTREPIDUS", "RUGOPS", "MICROCERATUS"
        };

        public static void IniciarNovoJogo()
        {
            Random gerador = new Random();
            palavraEscolhida = palavras[gerador.Next(palavras.Length)];
            letrasEncontradas = new char[palavraEscolhida.Length];

            for (int contador = 0; contador < letrasEncontradas.Length; contador++)
            {
                letrasEncontradas[contador] = '_';
            }
            quantidadeErros = 0;
            jogadorPerdeu = false;
            jogadorGanhou = false;
        }

        public static void VerificarLetra(char letra)
        {
            bool letraEncontrada = false;

            for (int contador = 0; contador < palavraEscolhida.Length; contador++)
            {
                if (letra == palavraEscolhida[contador])
                {
                    letrasEncontradas[contador] = letra;
                    letraEncontrada = true;
                }
            }

            if (!letraEncontrada) quantidadeErros++;

            AtualizarEstadoJogo();
        }

        private static void AtualizarEstadoJogo()
        {
            jogadorGanhou = string.Join("", letrasEncontradas) == palavraEscolhida;
            jogadorPerdeu = quantidadeErros > 5;
        }
    }
}