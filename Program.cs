using ModuleAPI.Models;
using ModuleAPI.Shared;
using WakeOnLanModule;

var server = new ModuleAPI.ModuleAPI(args);

var info = new ModuleInfo("WakeOnLan", "0.1.0");
server.SetModuleInfo(info);
server.SetDatabaseContext<AbstractDatabaseContext>();
server.SetActionHandler(new ActionHandler());
server.RunServer();