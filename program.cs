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

        switch (op)
        {
            case '+':
                Console.WriteLine($" the opertor is number1 + number2 = {number1 + number2}");
                break;
            case '-':
                Console.WriteLine($" the opertor is number1 - number2 = {number1 - number2}");
                break;
            case '*':
                Console.WriteLine($" the opertor is number1 * number2 = {number1 * number2}");
                break;
            case '/' when number1 > 0 && number2 > 0:
                Console.WriteLine($" the opertor is number1 / number2 = {number1 / number2}");
                break;
            default:
                Console.WriteLine("invalid operator you must return to enter daa");
                continue;
        }
            Console.WriteLine("are you want to contine Y/ N");
            char userAnswer = Console.ReadLine()[0];
            Console.WriteLine(userAnswer);
            if(userAnswer == 'n' ||  userAnswer == 'N')
            {
                break;
            }
    }
    
    }
}