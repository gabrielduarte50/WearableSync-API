using WearableSyncAPI.Application.Interface;
using WearableSyncAPI.Application.Service;

namespace WearableSyncAPI.Infra.Factory;

public class SmartbandFactory
{
    public static IManagerSmartbandData ManagerData(string model)
    {
        return model switch
        {
            "MiBand3" => new ManagerSmartbandDataMI4(),
            _ => throw new NotImplementedException($"Undeveloped Model: {model}.")
        };
    }
}
