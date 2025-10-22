namespace NexaSuite.Domain.Users;

public class GuestProfile(int nights, decimal bill)
{
    public int Nights { get; private set; } = nights;
    public decimal Bill { get; private set; } = bill;
}
