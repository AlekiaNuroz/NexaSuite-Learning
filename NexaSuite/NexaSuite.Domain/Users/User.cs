using NexaSuite.Domain.Common;

namespace NexaSuite.Domain.Users;

public class User(string name, string email) : EntityBase
{
    public string Name { get; private set; } = name;
    public string Email { get; private set; } = email;
    public List<string> Roles { get; private set; } = [];
    public Dictionary<string, object> Attributes { get; private set; } = [];

    public EmployeeProfile? EmployeeProfile { get; private set; }
    public GuestProfile? GuestProfile { get; private set; }
    public bool IsActive { get; private set; } = true;
    public DateTime LastLogin { get; private set; } = DateTime.UtcNow;

    public void AddRole(string role)
    {
        if (!Roles.Contains(role))
            Roles.Add(role);
    }

    public void SetEmployeeProfile(EmployeeProfile profile) => EmployeeProfile = profile;
    public void SetGuestProfile(GuestProfile profile) => GuestProfile = profile;

    public void DisplayInfo()
    {
        Console.WriteLine($"{Name} ({Email})");
        if (Roles.Any())
            Console.WriteLine($"Roles: {string.Join(", ", Roles)}");

        if (EmployeeProfile is not null)
            Console.WriteLine($"Employee: {EmployeeProfile.Position} | Discount: {EmployeeProfile.DiscountRate:P0}");
        if (GuestProfile is not null)
            Console.WriteLine($"Guest: {GuestProfile.Nights} nights | Bill: ${GuestProfile.Bill:F2}");
    }

    public decimal ApplyDiscount(decimal price)
    {
        if (EmployeeProfile is not null)
        {
            var discount = price * EmployeeProfile.DiscountRate;
            return price - discount;
        }
        return price;
    }

    public void UpdateLastLogin() => LastLogin = Touch();
}
