using System;

namespace ArrayTests
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string repeat = "y";
            string[] nameArray = new string[] { "Mike", "Bob", "Emma", "Barb" };
            string[] townArray = new string[] { "Detroit", "Northville", "Plymouth", "Livonia" };
            string[] foodArray = new string[] { "Chicken", "Pasta", "Steak", "Seafood" };
            while (repeat == "y")
            {

                Console.WriteLine("would you like to see a list of students?(y/n)");
                var studentList = Console.ReadLine();
                if (studentList == "y")
                {
                    var names = String.Join(", ", nameArray);
                    Console.WriteLine(names);
                }
                Console.WriteLine("Please enter a student number(1-4): ");               
                var studentNumber = int.Parse(Console.ReadLine());

                if (studentNumber > 0 && studentNumber <= nameArray.Length)
                {

                    studentNumber--;
                    Console.WriteLine($"Student {(studentNumber + 1)} is {nameArray[studentNumber]}. What would you like to know about them? Enter hometown or food: ");
                    var foodOrTown = Console.ReadLine().ToLower();

                    
                    if (foodOrTown.Contains("food"))
                    {
                        Console.WriteLine($"{nameArray[studentNumber]}'s favorite food is {foodArray[studentNumber]}.");
                    }
                    else if (foodOrTown.Contains("town"))
                    {                      
                        Console.WriteLine($"{nameArray[studentNumber]}'s hometown is {townArray[studentNumber]}.");
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid entry.  Please enter hometown or food: ");
                    }

                }
               else
                   Console.WriteLine("That is not a valid student number, please enter a student number(1-4): ");
                


                Console.WriteLine("Would you like to know about another student?(y/n) ");
                repeat = Console.ReadLine();

            }




            Console.WriteLine("Goodbye!");

            ////to display entire arrays
            //var names = String.Join(", ", nameArray);
            //Console.WriteLine(names);
        }


     
    }
}