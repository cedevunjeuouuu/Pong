using System;
using System.Net.Mail;

namespace un_jeu
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Game pong = new Game(60, 20);
            pong.Run();
            Console.ReadKey();
        }
    }
}