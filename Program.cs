namespace Something
{
    internal class Program
    {
        //Comments for process of sharing information
        //SAVE your work before pulling
        //'git add Program.cs' to add your save file
        //

        public static string WordSelection() 
        { 
            return
        }

        public static string Jumble() 
        {
            return
        }

        public static void user(string answer)

        {
            //sets up values and takes a guess from the user
            string userguess, temp;
            Console.WriteLine("Please enter your guess:\t");
            userguess = Console.ReadLine();

            //This part of the code is for when the user guesses correctly.
            if (userguess == answer)
            {
                Console.WriteLine($"Your guess was {userguess}... Your guess was correct. Well done!!!");
            }

            //This part of the code is for when the user guesses incorrectly.
            else if (userguess != answer) 
            {
                Console.WriteLine($"Your guess was {userguess}. That was incorrect. The correct answer was {answer}. Better luck next time...");
            }

            //This part of the code is for a stalemate if it were to somehow occur.
            else
            {
                Console.WriteLine("I do not understand how you have got here. I am impressed none the less.");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}