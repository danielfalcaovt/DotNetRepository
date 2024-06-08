namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type your name: ");
            string username = Console.ReadLine();
            string lengthMessage = showMessage(username);
            Console.WriteLine(lengthMessage);
        }    
        static string showMessage(string person)
        {
            if (person.Length >= 10)
            {
                return "Greather than 10 letters";
            }
            else if (person.Length == 10)
            {
                return "It's 10 letters";
            }
            else
            {
                return "Small than 10 letters";
            }
        }
    }
}