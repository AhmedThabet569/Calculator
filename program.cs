internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Wecome To Simple Calculator");

        /**
         * take 2 number from user and preform some oretor 
         * 
         */
        while (true)
        {
            Console.WriteLine("please enter number 1");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter number 2");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter opertor from : + , - , * , /");
            Console.Write("Enter an operator (+, -, *, /): ");

            char op = Console.ReadLine()[0];

            Console.WriteLine($"You entered: {op}");


            
        }
    }
}