namespace NexaSuite.Week2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Enter guest name: ");
            string guestName = Console.ReadLine();

            Console.Write("Enter number of nights: ");
            int nights = Convert.ToInt32(Console.ReadLine());

            decimal ratePerNight = 120.50m;

            if (nights >= 7)
            {
                Console.WriteLine("10% discount applied!");
                ratePerNight *= 0.9m;
            }
            else
            {
                Console.WriteLine("Regular rate applies.");
            }

            for (int i = 1; i <= nights; i++)
                Console.WriteLine($"Night {i}: reserved for {guestName}");

            var total = nights * ratePerNight;

            Console.WriteLine($"Guest Name: {guestName}");
            Console.WriteLine($"Number of Nights: {nights}");
            Console.WriteLine($"Rate per Night: ${decimal.Round(ratePerNight, 2)}");
            Console.WriteLine($"Total Cost: ${decimal.Round(total, 2)}");
        }
    }
}