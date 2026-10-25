using Microsoft.EntityFrameworkCore;
using ManagmentServices.Domain.Entities;

namespace ManagmentServices.Infrastructure.Data;

public class ApplicationDBContext : DbContext
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
        : base(options)
    {
    }

    public DbSet<TaskItem> TaskItems { get; set; }
}