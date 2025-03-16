using WearableSyncAPI.Domain.Entity;

namespace WearableSyncAPI.Application.Interface.Repository;

public interface ISmartbandDataRepository
{
    Task AddAsync(DataHealth dados);
    Task<List<DataHealth>> GetAllAsync();
    Task<DataHealth?> GetByIdAsync(int id);
}
