using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace un_jeu
{
    class Ball
    {
        public int X { set; get; }
        public int Y { set; get; }
        
        int zwrotX;
        
        int zwrotY;
        
        int i;
        
        public int boardHeight;
        
        public int boardWidht;
        
        public int direction ;
        
        public Ball (int x, int y, int boardHeight, int boardWidht)
        {
            X = x;
            Y = y;
            this.boardHeight = boardHeight;
            this.boardWidht = boardWidht;
            zwrotX = -1;
            zwrotY = 1;
        }

        public void Logic(Paddle paddle1, Paddle paddle2)
        {
            Console.SetCursorPosition(X, Y);
            Console.Write("\0");
            if (Y <= 1 || Y >= boardHeight)
            {
                zwrotY *= -1;
            }
            if(((X==3|| X==boardWidht)&&(paddle1.Y - (paddle1.Lenght/2))<= Y && (paddle1.Y + (paddle1.Lenght/2)>Y)))
            {
                zwrotX *= -1;
                if (Y == paddle1.Y)
                {
                    direction = 0;
                }

                if ((Y >= (paddle1.Y - (paddle1.Lenght/2 )) && Y < paddle1.Y))
                {
                    direction = 2;
                }
                if(Y > paddle1.Y && Y < (paddle1.Y + (paddle1.Lenght/2 )))
                {
                    direction = 1;
                }
            }
            if(((X==boardWidht - 3|| X==boardWidht)&&(paddle2.Y - (paddle2.Lenght/2))<= Y && (paddle2.Y + (paddle2.Lenght/2)>Y)))
            {
                zwrotX *= -1;
                if (Y == paddle2.Y)
                {
                    direction = 0;
                }

                if ((Y >= (paddle2.Y - (paddle2.Lenght/2 )) && Y < paddle2.Y) )
                {
                    direction = 2;
                }
                if(Y > paddle2.Y && Y < (paddle2.Y + (paddle2.Lenght/2 )))
                {
                    direction = 1;
                }
            }

            if (X == 0 || X == 60)
            {
                Game pong = new Game(60, 20);
                Thread.Sleep(3000);
                pong.Run();
            }

            switch (direction)
                {
                    case 0:
                        X += zwrotX;
                        break;
                    case 1 :
                        X += zwrotX;
                        Y += zwrotY;
                        break;
                    case 2 :
                        X += zwrotX;
                        Y += -zwrotY;
                        break;
                }
            
        }

        public void Write()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(X,Y);
            Console.Write("■");
            Console.ForegroundColor = ConsoleColor.White;
        }
        
    }
   
}