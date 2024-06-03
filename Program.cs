namespace Assignment5._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a series of numbers separated by spaces:");
            string input = Console.ReadLine();
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();
            Dictionary<int, int> counts = new Dictionary<int, int>();
            foreach (int num in numbers)
            {
                if (counts.ContainsKey(num))
                    counts[num]++;
                else
                    counts[num] = 1;
            }

            int[] distinctNumbers = counts.Select(kv => kv.Key).ToArray();

            int[] duplicateNumbers = counts.Where(a => a.Value > 1)
                             .Select(kv => kv.Key).ToArray();
            Console.WriteLine("original array");
            PrintArray(numbers);

            Console.WriteLine("distinct array");
            PrintArray(distinctNumbers);

            Console.WriteLine("duplicate array");
            PrintArray(duplicateNumbers);

            Console.ReadLine();
        }

        static void PrintArray(int[] numArray)
        {
            foreach (int num in numArray)
            {
                Console.WriteLine($"{num} ");
            }
            Console.WriteLine();
        

            
        }
    }
}
