namespace NexaSuite.Week3;

internal class Reservation
{
    public Guest Guest { get; private set; }
    public Room Room { get; private set; }
    public decimal TotalCost => Guest.Bill;

    public Reservation(Guest guest, Room room)
    {
        Guest = guest;
        Room = room;
    }

    public void DisplaySummary()
    {
        Console.WriteLine($"\nReservation Summary:");
        Console.WriteLine($"{Guest.Name}\n");
        Console.WriteLine($"Room: {Room.Number}");
        Console.WriteLine($"Rate per night: ${Room.RatePerNight:F2}");
        Console.WriteLine($"Number of nights: {Guest.Nights}");
        Console.WriteLine($"Subtotal: {Room.RatePerNight * Guest.Nights}");
        Console.WriteLine($"Discounts applied: ${Room.RatePerNight * Guest.Nights - TotalCost:F2}");
        Console.WriteLine($"Total: ${TotalCost:F2}");
    }
}
