using System;
using Konsole;

namespace CRPG
{
    class GameManagment
    {
        public static void AgradecimentosFinais()
        {
            Console.Clear();

            var agradecimento = Window.OpenBox("Parabéns!!!", 40, 5);
            agradecimento.WriteLine("Você conseguiu terminar o jogo.");
            agradecimento.WriteLine("Obrigado por jogar.");

            Console.ReadKey();

            Environment.Exit(0);
        }
    }
}