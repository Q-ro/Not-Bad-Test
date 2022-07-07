class CollatzCalculator
{

    public List<int> ResultSequence = new List<int>();


    public void Calculate(int starting_value)
    {
        var currentValue = starting_value;
        Console.WriteLine(currentValue);

        while (currentValue > 1)
        {
            currentValue = (currentValue % 2 == 0) ? currentValue / 2 : 3 * currentValue + 1;
            ResultSequence.Add(currentValue);
            Console.WriteLine(currentValue);
        }

    }


}