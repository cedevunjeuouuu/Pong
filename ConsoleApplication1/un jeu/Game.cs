namespace un_jeu
{
    public class Game
    {
        
        private int width;
        private int height;
        private Board board1;
        public Game(int width, int height)
        {
            this.width = width;
            this.height = height;
            board1 = new Board(width, height);
        }

        public void Run()
        {
            board1.Write();    
        }
    }
}