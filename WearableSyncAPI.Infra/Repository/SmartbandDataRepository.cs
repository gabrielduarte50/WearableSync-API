using Microsoft.EntityFrameworkCore;
using WearableSyncAPI.Application.Interface.Repository;
using WearableSyncAPI.Domain.Entity;
using WearableSyncAPI.Infra.Persistence;

namespace WearableSyncAPI.Infra.Repository;

public class SmartbandDataRepository : ISmartbandDataRepository
{
    private readonly DatabaseContext _context;

    public SmartbandDataRepository(DatabaseContext context)
    {
        _context = context;
    }

    public async Task AddAsync(DataHealth dados)
    {
        await _context.DataHealth.AddAsync(dados);
        await _context.SaveChangesAsync();
    }

    public async Task<List<DataHealth>> GetAllAsync()
    {
        return await _context.DataHealth.ToListAsync();
    }

    public async Task<DataHealth?> GetByIdAsync(int id)
    {
        return await _context.DataHealth.FindAsync(id);
    }
}
