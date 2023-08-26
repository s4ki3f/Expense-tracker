using Expense_Tracker.Areas.Identity.Data;
using Expense_Tracker.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker.Data;

public class Expense_TrackerContext : IdentityDbContext<Expense_TrackerUser>
{
    public Expense_TrackerContext() { }
    public Expense_TrackerContext(DbContextOptions<Expense_TrackerContext> options)
        : base(options)
    {
    }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<Category> Categories { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
