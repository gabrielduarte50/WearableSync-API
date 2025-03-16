using WearableSyncAPI.Domain.Entity.Common;

namespace WearableSyncAPI.Domain.Entity;

public class DataHealth : BaseEntity
{
    public DateTime CollectAt { get; set; }
    public int TotalSteps { get; set; }
    public string WalkSpeed { get; set; } = string.Empty;
    public int Rhr { get; set; }
    public string? WalkDistance { get; set; }
    public string? AvgHeartRate { get; set; }
    public string? TotalCalorie { get; set; }
}
