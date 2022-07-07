internal class Program
{
    private static void Main(string[] args)
    {
        List<int> testList = new List<int> { 1, 15, 1616, 6, 25, 13, 88 };
        int desiredIndex = 0;
        bool correctInput = false;

        Console.WriteLine("Basic Programming Task :" + Environment.NewLine);
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine("Write a function that allows user to access an item in the list with an arbitrary index i" + Environment.NewLine);
        Console.WriteLine(Environment.NewLine);

        while (!correctInput)
        {
            Console.WriteLine("Input the desired index : ");

            try
            {
                desiredIndex = Convert.ToInt32(Console.ReadLine());
                correctInput = true;
            }
            catch (System.Exception)
            {

                Console.WriteLine("Invalid input, please type a numeric value" + Environment.NewLine);
            }
        }

        Console.WriteLine("The return value is : " + LoopbackListReader(testList, desiredIndex));

    }
    public static int LoopbackListReader(List<int> list, int i)
    {
        int value = 0;

        value = list[WrapNumber(0, list.Count, i)];

        return value;

        int WrapNumber(int floor, int ceiling, int valueToWrap)
        {
            return (valueToWrap < floor) ? ceiling - (floor - valueToWrap) % (ceiling - floor) : valueToWrap = floor + (valueToWrap - floor) % (ceiling - floor);
        }
    }
}