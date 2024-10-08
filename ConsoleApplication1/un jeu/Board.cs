using System;

namespace un_jeu
{
    public class Board
    {
        public int Height { set; get; }
        public int Width { set; get; }

        public Board(int width, int height)
        {
            Height = height;
            Width = width;
        }

        public void Write()
        {
            for (int i = 1; i <= Width; i++)
            {
                Console.SetCursorPosition(i,0);
                Console.Write("-");
            }
            for (int i = 1; i <= Width; i++)
            {
                Console.SetCursorPosition(i, (Height+1));
                Console.Write("-");
            }

            for (int i = 1; i <= Height; i++)
            {
                Console.SetCursorPosition(0,i);
                Console.Write("|");
            }

            for (int i = 1; i <= Height; i++)
            {
                Console.SetCursorPosition((Width+1),i);
                Console.Write("|");
            }
            Console.SetCursorPosition(0,0);
            Console.Write("+");
            Console.SetCursorPosition(Width+1,0);
            Console.Write("+");
            Console.SetCursorPosition(0,Height+1);
            Console.Write("+");
            Console.SetCursorPosition(Width+1,Height+1);
            Console.Write("+");
                
        }
    }
}