using System.Collections.Generic;
using webapidotnetcore.Models;

namespace webapidotnetcore.Data
{
    public interface IWebApiRepo
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
    }
}