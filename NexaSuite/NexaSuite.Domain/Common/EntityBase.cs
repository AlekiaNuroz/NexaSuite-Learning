namespace NexaSuite.Domain.Common;

public abstract class EntityBase
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; private set; } = DateTime.UtcNow;
    public DateTime Touch() => UpdatedAt = DateTime.UtcNow;
}
