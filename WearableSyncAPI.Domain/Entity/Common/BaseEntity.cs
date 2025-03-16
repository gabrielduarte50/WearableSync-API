namespace WearableSyncAPI.Domain.Entity.Common;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public string Model { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? DeletedAt { get; set; }
}
