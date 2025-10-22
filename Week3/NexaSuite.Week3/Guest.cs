namespace NexaSuite.Week3;

internal class Guest
{
    public string Name { get; private set; }
    public int Nights { get; private set; }
    public decimal Bill { get; private set; }

    public Guest(string name, int nights, decimal ratePerNight)
    {
        Name = name;
        Nights = nights < 0 ? 0 : nights;
        Bill = CalculateBill(ratePerNight);
    }

    private decimal CalculateBill(decimal rate)
    {
        if (Nights >= 7)
        {
            Console.WriteLine($"{Name}: 7+ nights booked. 10% discount applied!");
            rate *= 0.9m;
        }
        else
        {
            Console.WriteLine($"{Name}: Regular rate applies.");
        }
        return Nights * rate;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"{Name,-15} | {Nights,2} nights | ${Bill,8:F2}");
    }
}
