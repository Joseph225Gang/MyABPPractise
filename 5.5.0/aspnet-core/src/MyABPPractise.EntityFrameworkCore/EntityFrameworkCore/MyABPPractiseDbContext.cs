using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyABPPractise.Authorization.Roles;
using MyABPPractise.Authorization.Users;
using MyABPPractise.MultiTenancy;
using MyABPPractise.Authorization.Person;

namespace MyABPPractise.EntityFrameworkCore
{
    public class MyABPPractiseDbContext : AbpZeroDbContext<Tenant, Role, User, MyABPPractiseDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MyABPPractiseDbContext(DbContextOptions<MyABPPractiseDbContext> options)
            : base(options)
        {
        }
        public DbSet<Person> Persons { get; set; }
    }
}
