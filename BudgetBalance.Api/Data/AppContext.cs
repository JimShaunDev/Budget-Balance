using BudgetBalance.Domain;
using Microsoft.EntityFrameworkCore;

namespace BudgetBalance.Api.Data
{
    public class AppContext : DbContext
    {
        public DbSet<TaskModel> Tasks { get; set; }

        public AppContext(DbContextOptions<AppContext> options)
        : base(options)
        { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseMySQL("server=127.0.0.1;database=BudgetBalanceDb;uid=root;pwd=dbpassword");
        }
    }
}
