using System.Collections.Generic;
using System.Linq;
using webapidotnetcore.Models;

namespace webapidotnetcore.Data
{
    public class SqlCommenderRepo : IWebApiRepo
    {
        private CommanderContext _context;

        public SqlCommenderRepo(CommanderContext context)
        {
            _context = context;
        }
       public IEnumerable<Command> GetAllCommands()
       {
            return _context.Commands.ToList();
       }

       public Command GetCommandById(int id)
       {
           return _context.Commands.FirstOrDefault(x => x.Id == id);
       }
    }
}