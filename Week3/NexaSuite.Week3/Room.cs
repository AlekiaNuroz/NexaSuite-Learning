namespace NexaSuite.Week3;

internal class Room
{
    public int Number { get; private set; }
    public decimal RatePerNight { get; private set; }

    public Room(int number, decimal ratePerNight)
    {
        Number = number;
        RatePerNight = ratePerNight;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Room {Number} | Rate: ${RatePerNight:F2}/night");
    }
}
