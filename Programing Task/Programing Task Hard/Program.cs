internal partial class Program
{
    private static void Main(string[] args)
    {
        var calculator = new CollatzCalculator();
        int desiredStartingPoint = 0;
        bool correctInput = false;

        Console.WriteLine("Harder Programming Task :" + Environment.NewLine);
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine("write a class that calculates Collatz conjecture" + Environment.NewLine);
        Console.WriteLine(Environment.NewLine);

        while (!correctInput)
        {
            Console.WriteLine("Input the desired starting point : ");

            try
            {
                desiredStartingPoint = Convert.ToInt32(Console.ReadLine());
                correctInput = true;
            }
            catch (System.Exception)
            {

                Console.WriteLine("Invalid input, please type a numeric value" + Environment.NewLine);
            }
        }

        calculator.Calculate(desiredStartingPoint);
    }
}