
class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine(CalculateAverage([1, 2, 3]));

    }
    static int CalculateAverage(int[] ints)
    {
        //return ints.Average();

        int sum = 0;
        for (int i = 0; i < ints.Length; i++)
        {
            sum += ints[i];
        }

        return sum / ints.Length;
    }
}