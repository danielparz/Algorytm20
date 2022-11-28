namespace Algorytm20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> output = new List<int>();

            if (input.Count % 2 != 0)
            {
                for (int i = input.Count / 2; i > 0; i--)
                {
                    output.Add(input[(input.Count / 2) - i]);
                    output.Add(input[(input.Count / 2) + i]);
                }
                output.Add(input.Count / 2 + 1);
            }
            else
            {
                for (int i = input.Count / 2; i > 0; i--)
                {
                    output.Add(input[(input.Count / 2) - i]);
                    output.Add(input[(input.Count / 2) + i - 1]);
                }
            }

            foreach (int i in output)
                Console.Write($" {i}, ");
        }
    }
}