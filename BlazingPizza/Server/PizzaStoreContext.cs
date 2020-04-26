using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BlazingPizza.Server
{
    public class PizzaStoreContext : ApiAuthorizationDbContext<PizzaStoreUser>
    {
        public PizzaStoreContext(DbContextOptions options,IOptions<OperationalStoreOptions> operationalStoreOptions)
            :base(options,operationalStoreOptions)
        { }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<PizzaSpecial> Specials { get; set; }
        public DbSet<Topping> Toppings { get; set; }
        public DbSet<NotificationSubscription> NotificationSubscriptions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Configure a many to many relation  "special -> topping" relationship */
            builder.Entity<PizzaTopping>().HasKey(pst => new { pst.PizzaId, pst.ToppingId });
            builder.Entity<PizzaTopping>().HasOne<Pizza>().WithMany(ps => ps.Toppings);
            builder.Entity<PizzaTopping>().HasOne(pst => pst.Topping).WithMany();

            /* InLine the Lat-Long pairs in Order rather than having a foreign key to another table */
            builder.Entity<Order>().OwnsOne(o => o.DeliveryLocation);

            /* Seed the Toppings Table in the Database */
            builder.Entity<Topping>().HasData(new Topping
            {
                Id = 1,
                Name = "Extra cheese",
                Price = 2.50m,
            });
            builder.Entity<Topping>().HasData(new Topping
            {
                Id=2,
                Name = "American bacon",
                Price = 2.99m,
            });
            builder.Entity<Topping>().HasData(new Topping
            {
                Id=3,
                Name = "British bacon",
                Price = 2.99m,
            });
            builder.Entity<Topping>().HasData(new Topping
            {
                Id=4,
                Name = "Canadian bacon",
                Price = 2.99m,
            });
        }
    }
}
