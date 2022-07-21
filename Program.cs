namespace RockPaperScissor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userWins = 0;
            int compWins = 0;

            while(userWins < 3 && compWins < 3)
            {
                Console.WriteLine($"PLayer Wins: {userWins} | Computer Wins: {compWins}");
                Console.WriteLine("What would you like to throw?");
                Console.WriteLine("1) Rock");
                Console.WriteLine("2) Paper");
                Console.WriteLine("3) Scissors");
                string gesture = Console.ReadLine();
                int numberForConstructor = int.Parse(gesture);

                Game game = new Game(numberForConstructor);
               string winner =  game.winner();
               if(winner == "computer")
                {
                    compWins++;
                } else if(winner == "user")
                {
                    userWins++;
                }
            }

        }
    }
}