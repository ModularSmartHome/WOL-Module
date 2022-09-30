using Microsoft.AspNetCore.Mvc;
using ModuleAPI.Models;

namespace WakeOnLanModule;

public class ActionHandler : IActionHandler
{
    public async Task<ActionResult> HandleAction(string action, object payload)
    {
        switch (action)
        {
            default:
                return await new Controller().PerformDefaultAction(payload);
        }
    }
}