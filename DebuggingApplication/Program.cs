namespace debuggingAplication
{
    class Debug
    {
        public static void Main(string[] args)
        {
            var userResponse = Console.ReadLine();
            // if we give integer insted of string in that time it will give 
            if (Convert.ToBoolean(int.Parse(userResponse)))
            {
                Console.WriteLine("The entered value is a integer");
            }
        }
    }
}