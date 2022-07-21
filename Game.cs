using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    internal class Game
    {
        public static List<string> gestures = new List<string>() {"", "Rock", "Paper", "Scissors"};
        public string userChoice;
        public string computerChoice;

        public Game(int userChoice)
        {
            this.userChoice = gestures[userChoice];

            Random random  = new Random();
            int randomNumber = random.Next(1,4);
            computerChoice = gestures[randomNumber];
        }

        public string winner()
        {
            if(userChoice == computerChoice)
            {
                Console.WriteLine($"both players chose {userChoice}");
                return "draw";
            } else if(userChoice == "Rock" && computerChoice == "Paper" || userChoice == "Scissors" && computerChoice == "Rock" || userChoice == "Paper" && computerChoice == "Scissors")
            {
                Console.WriteLine($"computer won with {computerChoice} and user picked {userChoice}");
                return "computer";
            } else if(userChoice == "Paper" && computerChoice == "Rock" || userChoice == "Rock" && computerChoice == "Scissors" || userChoice == "Scissors" && computerChoice == "Paper")
            {
                Console.WriteLine($"user won with {userChoice} and computer picked {computerChoice}");
                return "user";
            }
            return "this should never return";
        }
    }
}
