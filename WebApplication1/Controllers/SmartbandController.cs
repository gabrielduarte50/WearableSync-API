using Microsoft.AspNetCore.Mvc;
using WearableSyncAPI.Application.Interface;
using WearableSyncAPI.Domain.Entity;
using WearableSyncAPI.Infra.Factory;

namespace WearableSyncAPI.Controllers;

public class SmartbandController : ControllerBase
{
    /// <summary>
    /// Get data
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    [HttpGet("dados")]
    public async Task<IActionResult> ObterDados([FromQuery] string model)
    {
        try
        {
            IManagerSmartbandData service = SmartbandFactory.ManagerData(model);
            DataHealth dados = await service.GetSmartbandData();
            return Ok(dados);
        }
        catch (NotImplementedException ex)
        {
            return BadRequest(new { mensagem = ex.Message });
        }
    }
}
