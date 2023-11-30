using Microsoft.EntityFrameworkCore;
using Pustok_project.Models;

namespace Pustok_project.Contexts;
public class PustokDbContext:DbContext
{
    public DbSet<Slider> Sliders { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server= DESKTOP-76LNOO9\\SQLEXPRESS;Database = PustokProject;Trusted_Connection=true");
        base.OnConfiguring(optionsBuilder);
    }

}
