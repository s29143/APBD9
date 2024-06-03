using Microsoft.EntityFrameworkCore;

namespace APBD9.Context;

public class ApbdContext : DbContext
{
    protected ApbdContext()
    {
    }

    public ApbdContext(DbContextOptions options) : base(options)
    {
    }
}