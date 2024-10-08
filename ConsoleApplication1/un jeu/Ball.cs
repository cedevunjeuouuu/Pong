using System;
using System.Security.Cryptography.X509Certificates;

namespace un_jeu
{
    class Ball
    {
        public int X { set; get; }
        public int Y { set; get; }
        
        int zwrotX;
        
        int zwrotY;
        
        int i;
        
        int boardHeight;
        
        int boardWidht;
        
        public int direction ;
        
        public Ball (int x, int y)
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
            Console.SetCursorPosition(X,Y);
            Console.Write("\0");
            if (Y <= 1 || Y >= boardHeight)
            {
                zwrotY *= -1;
            }

            if (((X == 3 || X == boardWidht - 3) && (paddle1.Y - (paddle1.Lenght / 2)) <= Y && (paddle1.Y + (paddle1.Lenght / 2)) > Y))
            {
                zwrotX *= 1;
                if (Y == paddle1.Y)
                {
                    direction = 0;
                }

                if (Y >= paddle1.Y - paddle1.Lenght/2)
                {
                    direction = 1;
                }

                switch (direction)
                {
                   case 0:
                       X += zwrotX;
                       Y += zwrotY;
                       break;
                }
                
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