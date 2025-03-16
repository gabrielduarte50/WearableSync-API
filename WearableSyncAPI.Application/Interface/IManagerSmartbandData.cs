using WearableSyncAPI.Domain.Entity;

namespace WearableSyncAPI.Application.Interface;

public interface IManagerSmartbandData
{
    Task<DataHealth> GetSmartbandData();
}
