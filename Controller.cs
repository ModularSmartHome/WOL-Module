using Microsoft.AspNetCore.Mvc;

namespace WakeOnLanModule;

public class Controller : ControllerBase
{

    public async Task<ActionResult> PerformDefaultAction(object payload)
    {
        return Ok(payload);
    }
    
}