namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("The second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result = num1 + num2;
            Console.WriteLine($"Your result is {result}");
        }
    }
}