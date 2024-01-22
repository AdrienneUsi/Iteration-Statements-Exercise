namespace IterationStatements
{
    public class Program
    { static void Main(string[] args)

    {
        PrintRange(10, -2);
            Console.WriteLine(IsEqual(2, 8));
    }
    
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintRange(int ceiling, int floor)
        {
            for(int i = 1000; i >= floor; i --)
            {
                Console.WriteLine(i);
            }

        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void UpByThree()
        {
            for(int i =3; i <=999; i+=3)
            { Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool IsEqual(int a, int b)
        {
            if (a == b)
            {
                return true;
            }
            return false;
        }
        //Write a method to check whether a given number is even or odd
        public static bool EvenOrOdd(int num)
        {
            if(num % 2 == 0)
            { return true;
            }
            else

            { return false;
            }
        }
        
        //Write a method to check whether a given number is positive or negative
        public static void IsPositive(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"{num} is positive!");
            }
            else
            {
                Console.WriteLine($"{num} is negative ");
            }
            
        }
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void CanVote()
        {
            Console.WriteLine("Please enter your age");
            var canParse = int.TryParse(Console.ReadLine(), out int age);
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
       
        {
            
        }
    }
}
