using Abp.Zero.EntityFrameworkCore;
using JSFileSystem.Authorization.Roles;
using JSFileSystem.Authorization.Users;
using JSFileSystem.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace JSFileSystem.EntityFrameworkCore;

public class JSFileSystemDbContext : AbpZeroDbContext<Tenant, Role, User, JSFileSystemDbContext>
{
    /* Define a DbSet for each entity of the application */

    public JSFileSystemDbContext(DbContextOptions<JSFileSystemDbContext> options)
        : base(options)
    {
    }
}
