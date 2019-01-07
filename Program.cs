using System;

namespace cs_day_2
{
  class Program
  {
    static void Main(string[] args)
    {
      int secret;
      bool won = false;


      Console.Clear();

      Console.WriteLine("Guess my number! 1-50");
      Random random = new Random();
      secret = random.Next(1, 51);


      while (!won)
      {
        Console.WriteLine(secret);
        string guessStr = Console.ReadLine();
        int guess;

        if (Int32.TryParse(guessStr, out guess))
        {
          if (guess == secret)
          {
            Console.WriteLine("You win!");
            Console.WriteLine("Play Again? (Y/N)");
            string play = Console.ReadLine();
            if (play.ToUpper() != "Y")
            {
              won = true;
            }
            else
            {
              secret = random.Next(1, 51);
              System.Console.WriteLine("I have a new number!");
              continue;
            }
          }
          else if (guess > secret)
          {
            Console.WriteLine("Guess too high");
          }
          else
          {
            Console.WriteLine("Guess too low");
          }
        }
        else
        {
          Console.WriteLine("Not a number! Please try again!");
        };
      }
    }
  }
}
