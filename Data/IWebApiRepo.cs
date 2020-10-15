using System.Collections.Generic;
using webapidotnetcore.Models;

namespace webapidotnetcore.Data
{
    public interface IWebApiRepo
    {
        bool SaveChanges();
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command cmd);
        void UpdateCommand(Command cmd);
        void DeleteCommand(Command cmd);
    }
}