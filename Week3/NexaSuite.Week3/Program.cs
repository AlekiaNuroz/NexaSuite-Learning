namespace NexaSuite.Week3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("=== NexaSuite Guest Registry v2 ===\n");

            Console.Write("Enter guest name: ");
            string name = Console.ReadLine()!;

            Console.Write("Enter number of nights: ");
            int nights = int.TryParse(Console.ReadLine(), out nights) ? nights : 0;

            Console.Write("Enter room number: ");
            int roomNumber = int.TryParse(Console.ReadLine(), out roomNumber) ? roomNumber : 101;

            var room = new Room(roomNumber, 120.50m);
            var guest = new Guest(name, nights, room.RatePerNight);
            var reservation = new Reservation(guest, room);

            Console.Clear();
            room.DisplayInfo();
            guest.DisplayInfo();
            reservation.DisplaySummary();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
