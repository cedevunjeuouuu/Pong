using System;
using System.Configuration;

namespace un_jeu
{
    public class Paddle
    {
        
        public int X { set; get; }
        public int Y { set; get; }
        public int Lenght { set; get; }

        int boardHeight;
        
        public Paddle (int x, int y, int boardHeight)
        {
            X = x;
            Y = boardHeight / 2;
            Lenght = boardHeight / 3;
            this.boardHeight = boardHeight;
        }

        public void up()
        {
            if ((Y - 1 - (Lenght / 2)) != 0)
            {
                Console.SetCursorPosition(X,(Y+ Lenght / 2)-1);
                Console.Write("\0");
                Y--;
                Write();


            }
        }
        
        public void down()
        {
            if ((Y - 1 - (Lenght / 2)) != 14)
            {
                Console.SetCursorPosition(X,(Y + (Lenght / 2)-1));
                Console.Write("\0");
                Y++;
                Write();
                
                
                
            }
        }
        
        

        public void Write()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = (Y - (Lenght / 2)); i < (Y + (Lenght / 2));i++)
            {
                Console.SetCursorPosition(X,i);
                Console.Write("|");
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }

   
}