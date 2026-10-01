namespace My_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mohamed's carpet cleaning service charges !");
            Console.WriteLine("25$ per small");
            Console.WriteLine("35$ per large");
            Console.WriteLine("sales tax rate=6% ");
            int per_small = 25;
            int per_large = 35;

            Console.WriteLine("What is the number of your small carpets?");
            int count_of_small = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the number of your large carpets?");
            int count_of_large = Convert.ToInt32(Console.ReadLine());

            int cost = count_of_small * per_small + count_of_large * per_large;
            Console.WriteLine($"so,cost= {cost}$");

            float tax = cost * 0.06f;
            Console.WriteLine($"tax= {tax}$");
            float Total_estimate = cost + tax;
            Console.WriteLine($"Total estimate is {Total_estimate}$");
        }
    }
}
