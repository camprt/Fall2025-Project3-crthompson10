using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Fall2025_Project3_crthompson10.Models;

namespace Fall2025_Project3_crthompson10.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Fall2025_Project3_crthompson10.Models.Movie> Movie { get; set; } = default!;

    public DbSet<Fall2025_Project3_crthompson10.Models.Actor> Actor { get; set; } = default!;

    public DbSet<Fall2025_Project3_crthompson10.Models.ActorMovie> ActorMovie { get; set; } = default!;
    
}