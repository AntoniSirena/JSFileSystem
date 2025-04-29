using Abp.Zero.EntityFrameworkCore;
using JSFileSystem.Authorization.Roles;
using JSFileSystem.Authorization.Users;
using JSFileSystem.Domain;
using JSFileSystem.MultiTenancy;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace JSFileSystem.EntityFrameworkCore;

public class JSFileSystemDbContext : AbpZeroDbContext<Tenant, Role, User, JSFileSystemDbContext>
{
    /* Define a DbSet for each entity of the application */

    public DbSet<Student> Students { get; set; }

    public JSFileSystemDbContext(DbContextOptions<JSFileSystemDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
