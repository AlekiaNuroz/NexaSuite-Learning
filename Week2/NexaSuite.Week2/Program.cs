namespace NexaSuite.Week2
{
    internal class Program
    {
        static List<(string Name, int Nights, decimal Bill)> guests = [];
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("=== NexaSuite Guest Registry ===\n");
            RegisterGuests();
            ShowGuests();
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        } 

        static void RegisterGuests()
        {
            while (true)
            {
                Console.Write("Guest name (or done): ");
                string? name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                    continue;
                if (name.Trim().Equals("done", StringComparison.CurrentCultureIgnoreCase))
                    break;
                Console.Write("Number of nights: ");
                if (!int.TryParse(Console.ReadLine(), out int nights))
                {
                    Console.WriteLine("Invalid input. Defaulting to 0 nights.");
                    nights = 0;
                }
                decimal total = CalculateBill(nights, 120.50m);
                guests.Add((name, nights, total));
            }
        }

        static decimal CalculateBill(int nights, decimal ratePerNight)
        {
            if (nights >= 7)
            {
                Console.WriteLine("7 or more nights booked. 10% discount applied!");
                ratePerNight *= 0.9m;
            }
            else
            {
                Console.WriteLine("Regular rate applies.");
            }
            return nights * ratePerNight;
        }

        static void ShowGuests()
        {
            Console.WriteLine("\nRegistered Guests:");
            foreach (var g in guests)
                Console.WriteLine($"{g.Name,-15} | {g.Nights,2} nights | ${g.Bill,8:F2}");
        }
    }
}