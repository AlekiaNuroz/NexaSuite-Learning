namespace NexaSuite.Domain.Users;

internal class GuestProfile(int nights, decimal bill)
{
    public int Nights { get; private set; } = nights;
    public decimal Bill { get; private set; } = bill;
}
