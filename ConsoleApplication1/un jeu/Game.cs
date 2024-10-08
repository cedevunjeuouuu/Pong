using System;
using System.Threading;

namespace un_jeu
{
    public class Game
    {
        private int width;
        private int height;
        private Board board1;
        private Paddle paddle1;
        private Paddle paddle2;
        private Ball ball;
        private ConsoleKeyInfo keyInfo;
        private ConsoleKey consoleKey;

        public Game(int width, int height)
        {
            this.width = width;
            this.height = height;
            board1 = new Board(width, height);
        }

        public void Setup()
        {
            paddle1 = new Paddle(2, height, board1.Height);
            paddle2 = new Paddle(width - 2, height, board1.Height);
            keyInfo = new ConsoleKeyInfo();
            consoleKey = new ConsoleKey();
            ball = new Ball(width / 2, height / 2);
        }

        public void Input()
        {
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
                consoleKey = keyInfo.Key;
            }
        }

        public void Run()
        {
            Setup();
            while (true)
            {
                Console.Clear();
                board1.Write();
                ball.Logic(paddle1, paddle2);
                ball.Write();
                Input();
                switch (consoleKey)
                {
                    case ConsoleKey.Z:
                        paddle1.up();
                        paddle2.up();
                        break;
                    case ConsoleKey.E:
                        paddle1.down();
                        paddle2.down();
                        break;
                }
                paddle1.Write();
                paddle2.Write();

                consoleKey = ConsoleKey.A;
                Thread.Sleep(10);
            }
        }
    }
}