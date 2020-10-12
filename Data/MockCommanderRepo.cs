using System.Collections.Generic;
using webapidotnetcore.Models;

namespace webapidotnetcore.Data
{
    public class MockCommanderRepo : IWebApiRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var command = new List<Command>
            {
                new Command{Id=1, HowTo="Boil an egg", Line="Boil Water", Platform="Kettle & Pen"},
                new Command{Id=2, HowTo="Boil an egg", Line="Boil Water", Platform="Kettle & Pen"},
                new Command{Id=3, HowTo="Boil an egg", Line="Boil Water", Platform="Kettle & Pen"}
            };

            return command;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=1, HowTo="Boil an egg", Line="Boil Water", Platform="Kettle & Pen"};
        }
    }
}