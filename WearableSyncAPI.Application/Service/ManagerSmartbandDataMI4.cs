using WearableSyncAPI.Application.Interface;
using WearableSyncAPI.Domain.Entity;

namespace WearableSyncAPI.Application.Service;

public class ManagerSmartbandDataMI4 : IManagerSmartbandData
{
    public async Task<DataHealth> GetSmartbandData()
    {
        await Task.Delay(1000); 

        return new DataHealth
        {
            Model = "MiBand3",
            CollectAt = DateTime.UtcNow,
            AvgHeartRate = "75",
            WalkDistance = "8000",
            WalkSpeed = "8000",
            TotalCalorie = "250"
        };
    }
}
