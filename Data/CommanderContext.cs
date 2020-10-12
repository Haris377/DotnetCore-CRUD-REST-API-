using Microsoft.EntityFrameworkCore;
using webapidotnetcore.Models;

namespace webapidotnetcore.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> options) : base(options)
        {
            
        }

        public DbSet<Command> Commands { get; set; }

    }
}