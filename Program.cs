namespace Something
{
    internal class Program
    {

        public static string WordSelection() 
        { 
            return
        }

        public static string Jumble() 
        {
            Random rand = new Random();
            String beanz = "hehehe";
            char temp;
            char[] letter = beanz.ToCharArray();
            int numSwap1 = rand.Next(0,beanz.Length);
            int numSwap2 = rand.Next(0, beanz.Length);
            String finalWords = new string(letter);
            return finalWords;
        }

        public static void user()

        {
               
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}