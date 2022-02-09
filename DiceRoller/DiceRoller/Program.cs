using System;

namespace test
{
    class Program
    {

        static void Main(string[] args)
        {
            string repeat = "y";

            Console.WriteLine("Please enter the number of sides on the dice:");
            //var userInput = Console.ReadLine();
            var userInput = int.Parse(Console.ReadLine());
            //int parsedInt;
            //var isInt = int.TryParse(userInput, out parsedInt);

            //int number = int.Parse(userInput);

            //if (isInt)
            //{
               // userInput = isInt;


                for (int i = 1; repeat == "y"; i++)
                {
                    
                    var toss = new Rolldice();
                    var rolled = toss.Roll(userInput);
                    var rolled2 = toss.Roll(userInput);
                    var diceSum = rolled + rolled2;
                    

                    if (userInput == 6)
                    {
                        Console.WriteLine($"Roll {i}");
                        Console.WriteLine($"You rolled a {rolled} and a {rolled2} ({diceSum} total)");
                        var win = toss.SixSides(rolled, rolled2);
                        Console.WriteLine(win);
                        if (diceSum == 2 || diceSum == 3 || diceSum == 12)
                        {
                            Console.WriteLine("Craps!");
                        }
                    }
                    else if (userInput > 0)
                    {
                        Console.WriteLine($"Roll {i}");
                        Console.WriteLine($"You rolled a {rolled} and a {rolled2} ({diceSum} total)");
                        if (diceSum == 2 || diceSum == 3 || diceSum == 12)
                        {
                            Console.WriteLine("Craps!");
                        }
                        if (rolled == rolled2)
                        {
                            Console.WriteLine("Doubles win!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("That is not a number of dice faces.  Please enter a new number of sides:");
                        userInput = int.Parse(Console.ReadLine());
                        continue;

                    }
                //}else
                    Console.WriteLine("Would you like to roll again? (y to continue) ");
                    repeat = Console.ReadLine();


                
            }
            Console.WriteLine("Goodbye!!");

        }


    }




    public class Rolldice
    {

        public int Roll(int diceSides)
        {
           
                var rand = new Random();
                diceSides++;
                var randomRoll = rand.Next(1, diceSides);

                return randomRoll;
         
        }




            public string SixSides(int roll1, int roll2)
            {
                string response;
                int sum = roll1 + roll2;

                if (roll1 == 1 && roll2 == 1)
                {
                   response =  "Snake Eyes!";
                }
                else if((roll1 == 1 && roll2 == 2) || (roll1 == 2 && roll2 == 1))
                {
                    response = "Ace Duece!";
                }
                else if(roll1 == 6 && roll2 == 6)
                {
                response = "Box Cars!";
                
                }
                else if(sum == 7 || sum == 11)
                {
                response = "Winner!!!";
                
                }
                else
                {
                    response = " ";
                }
               
 

                return response;
               
            }

        
            
           
    }
}
