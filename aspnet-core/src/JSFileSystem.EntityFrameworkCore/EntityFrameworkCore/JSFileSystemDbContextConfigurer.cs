using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace JSFileSystem.EntityFrameworkCore;

public static class JSFileSystemDbContextConfigurer
{
    public static void Configure(DbContextOptionsBuilder<JSFileSystemDbContext> builder, string connectionString)
    {
        builder.UseSqlServer(connectionString);
    }

    public static void Configure(DbContextOptionsBuilder<JSFileSystemDbContext> builder, DbConnection connection)
    {
        builder.UseSqlServer(connection);
    }
}
