namespace NexaSuite.Week3;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("=== NexaSuite User Composition Demo ===\n");

        var user = new User("Alice Johnson", "alice@nexasuite.com");
        user.AddRole("Employee");
        user.AddRole("Guest");

        user.SetEmployeeProfile(new EmployeeProfile("Front Desk", 4200m, 0.15m));
        user.SetGuestProfile(new GuestProfile(5, user.ApplyDiscount(600m)));

        user.DisplayInfo();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
