using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCsharpConsoleApp
{
    internal class NumberGame
    {
        int mGuess;

        void GenerateGuessNumber()
        {
            Random rand = new Random();
            mGuess = rand.Next(0, 20);
        }


        // Play the Number Game
        public void Play(string userName)
        {
            bool prompt = true;
            int count = 0;
            GenerateGuessNumber();

            while (true)
            {

                if(prompt)
                {
                    Console.WriteLine("Hey {0}, \nDo you want to play the Game?", userName);
                    string input = Console.ReadLine(); // yes or no
                    if (input.Equals("no") || input.Equals("exit"))
                    {
                        Console.WriteLine("Exiting the Game!!!");
                        break;
                    }
                }

                Console.WriteLine("Input the number between 0 to 20");

                string number = Console.ReadLine();
                int gNumber = 0;
                try
                {
                    gNumber = int.Parse(number);

                }
                catch
                {
                    Console.WriteLine("You entered wrong format input, please input\n integer" +
                        "between 0 to 20");
                    prompt = false;
                    continue;
                }

                ++count;

                // check the value of number is greater or smaller than guessed number
                if (gNumber < mGuess)
                {
                    prompt = false;
                    Console.WriteLine("Number must be higher!!");
                }
                else if (gNumber > mGuess)
                {
                    prompt = false;
                    Console.WriteLine("Number must be Smaller!!");

                }
                else
                {
                    Console.WriteLine("You Guessed it right with {0} times try, and restarting the Game", count);
                    count = 0;
                    prompt = true;
                    continue;
                }
            }
        }
    }
}
