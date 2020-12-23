using IdentitySample.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Identity
{
    public class Context : IdentityDbContext<User, Role, int>
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
    }
}
