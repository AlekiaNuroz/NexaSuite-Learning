namespace NexaSuite.Domain.Users;

internal class EmployeeProfile(string position, decimal salary, decimal discountRate = 0.10m)
{
    public string Position { get; private set; } = position;
    public decimal Salary { get; private set; } = salary;
    public decimal DiscountRate { get; private set; } = discountRate;
}
