using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BlazingPizza.Server
{
    public class PizzaStoreContext : ApiAuthorizationDbContext<PizzaStoreUser>
    {
        public PizzaStoreContext(DbContextOptions options,IOptions<OperationalStoreOptions> operationalStoreOptions) :base(options,operationalStoreOptions)
        { 
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<PizzaSpecial> Specials { get; set; }
        public DbSet<Topping> Toppings { get; set; }
        public DbSet<NotificationSubscription> NotificationSubscriptions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            #region /* Seed the Toppings table */
            builder.Entity<Topping>().HasData(new Topping(){Id = 1, Name = "Extra cheese",      Price = 2.50m});
            builder.Entity<Topping>().HasData(new Topping(){Id = 2, Name = "American bacon",    Price = 2.99m});
            builder.Entity<Topping>().HasData(new Topping(){Id = 3, Name = "British bacon",     Price = 2.99m});
            builder.Entity<Topping>().HasData(new Topping(){Id = 4, Name = "Canadian bacon",    Price = 5.00m});
            builder.Entity<Topping>().HasData(new Topping(){Id = 5, Name = "Tea and crumpets",  Price = 5.00m});
            builder.Entity<Topping>().HasData(new Topping(){Id = 6, Name = "Fresh-baked scones",Price = 4.50m});
            builder.Entity<Topping>().HasData(new Topping(){Id = 7, Name = "Bell peppers",      Price = 1.50m});
            builder.Entity<Topping>().HasData(new Topping(){Id = 8, Name = "Onions",            Price = 1.00m});
            builder.Entity<Topping>().HasData(new Topping(){Id = 9, Name = "Mushrooms",         Price = 1.00m});
            builder.Entity<Topping>().HasData(new Topping(){Id = 10,Name = "Pepperoni",         Price = 1.50m});
            
            builder.Entity<Topping>().HasData(new Topping(){Id = 11, Name = "Duck sausage",                 Price = 2.50m});
            builder.Entity<Topping>().HasData(new Topping(){Id = 12, Name = "Venison meatballs",            Price = 2.99m});
            builder.Entity<Topping>().HasData(new Topping(){Id = 13, Name = "Served on a silver platter",   Price = 2.99m});
            builder.Entity<Topping>().HasData(new Topping(){Id = 14, Name = "Lobster on top",               Price = 5.00m});
            builder.Entity<Topping>().HasData(new Topping(){Id = 15, Name = "Sturgeon caviar",              Price = 5.00m});
            builder.Entity<Topping>().HasData(new Topping(){Id = 16, Name = "Artichoke hearts",             Price = 4.50m});
            builder.Entity<Topping>().HasData(new Topping(){Id = 17, Name = "Fresh tomatoes",               Price = 1.50m});
            builder.Entity<Topping>().HasData(new Topping(){Id = 18, Name = "Basil",                        Price = 1.00m});
            builder.Entity<Topping>().HasData(new Topping(){Id = 19, Name = "Steak (medium-rare)",          Price = 1.00m});
            builder.Entity<Topping>().HasData(new Topping(){Id = 20, Name = "Blazing hot peppers",          Price = 1.50m});
            
            builder.Entity<Topping>().HasData(new Topping(){Id = 21,Name = "Buffalo chicken",   Price = 1.50m});
            builder.Entity<Topping>().HasData(new Topping(){Id = 22,Name = "Blue cheese",       Price = 1.50m});
            #endregion

            #region /* Seed the Pizza Specials table*/
            
            builder.Entity<PizzaSpecial>().HasData(new PizzaSpecial()
            {
                Id = 1,
                Name = "Basic Cheese Pizza",
                Description = "It's cheesy and delicious. Why wouldn't you want one?",
                BasePrice = 9.99m,
                ImageUrl = "img/pizzas/cheese.jpg"
            }); 
            builder.Entity<PizzaSpecial>().HasData(new PizzaSpecial()
            {
                Id = 2,
                Name = "The Baconatorizor",
                Description = "It has EVERY kind of bacon",
                BasePrice = 11.99m,
                ImageUrl = "img/pizzas/bacon.jpg"
            }); 
            builder.Entity<PizzaSpecial>().HasData(new PizzaSpecial()
            {
                Id = 3,
                Name = "Classic pepperoni",
                Description = "It's the pizza you grew up with, but Blazing hot!",
                BasePrice = 10.50m,
                ImageUrl = "img/pizzas/pepperoni.jpg"
            }); 
            builder.Entity<PizzaSpecial>().HasData(new PizzaSpecial()
            {
                Id = 4,
                Name = "Buffalo chicken",
                Description = "It's cheesy and delicious. Why wouldn't you want one?",
                BasePrice = 9.99m,
                ImageUrl = "img/pizzas/cheese.jpg"
            }); 
            builder.Entity<PizzaSpecial>().HasData(new PizzaSpecial()
            {
                Id = 5,
                Name = "Veggie Delight",
                Description = "It's like salad, but on a pizza",
                BasePrice = 11.50m,
                ImageUrl = "img/pizzas/salad.jpg"
            }); 
            builder.Entity<PizzaSpecial>().HasData(new PizzaSpecial()
            {
                Id = 6,
                Name = "Mushroom Lovers",
                Description = "It has mushrooms. Isn't that obvious?",
                BasePrice = 11.99m,
                ImageUrl = "img/pizzas/mushroom.jpg"
            }); 
            builder.Entity<PizzaSpecial>().HasData(new PizzaSpecial()
            {
                Id = 7,
                Name = "The Brit",
                Description = "When in London...",
                BasePrice = 8.99m,
                ImageUrl = "img/pizzas/brit.jpg"
            }); 
            builder.Entity<PizzaSpecial>().HasData(new PizzaSpecial()
            {
                Id = 8,
                Name = "Margherita",
                Description = "Traditional Italian pizza with tomatoes and basil",
                BasePrice = 9.99m,
                ImageUrl = "img/pizzas/margherita.jpg"
            });
            #endregion


            /* Configure a many to many relation  "special -> topping" relationship */
            builder.Entity<PizzaTopping>().HasKey(pst => new { pst.PizzaId, pst.ToppingId });
            builder.Entity<PizzaTopping>().HasOne<Pizza>().WithMany(ps => ps.Toppings);
            builder.Entity<PizzaTopping>().HasOne(pst => pst.Topping).WithMany();

            /* InLine the Lat-Long pairs in Order rather than having a foreign key to another table */
            builder.Entity<Order>().OwnsOne(o => o.DeliveryLocation);

           
        }
    }
}
