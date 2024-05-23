using HouseRentingSystem.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SpasOnlineMenuProjectFinal.Models;

namespace SpasOnlineMenuProjectFinal.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<HouseRentingSystem.Data.Entities.Dish> Dishes { get; set; }
        private List<Dish> dishes
           = new List<Dish>
       {
            new Dish()
            {
                Id=1,
                Title = "Яйца Бенедеикт",
                Ingredients = "яйца,питка, тънки резени бекон, магданоз,лимонов сок",
                Price = 18M,
               ImageUrl = "https://assets-eu-01.kc-usercontent.com/00b9925d-7322-014e-f702-6ef9aa1a28b4/f509cc3f-85ee-4f27-bd60-1384807311b5/01072018-293.jpg?w=1200&fm=webp&lossless=0&q=80"
            },
              new Dish()
            {
                 Id = 2,
                Title = "Бъркани яйца",
                Ingredients = "яйца, черен пипер, сметана",
                Price = 8.90M,
                ImageUrl = "https://media-cldnry.s-nbcnews.com/image/upload/t_social_share_1200x630_center,f_auto,q_auto:best/newscms/2020_04/1530595/fluffy-scrambled-eggs-today-main-200121-2.jpg"
            },
                new Dish()
            {
                    Id = 3,
                Title = "Телешки стек",
                Ingredients = "Телешки стек с чимичури сос, чушки пимиентос де падрон и пюре от сладък картоф",
                Price = 25.20M,
                ImageUrl = "https://dostavka.happy.bg/remote/files/images/215620/fit_640_400.png?rev=1697484896"
            },
                new Dish()
                {
                    Id = 4,
                    Title = "Ребра Иберико По Азиатски",
                    Ingredients = "Свински ребра с азиатски барбекю сос, кашу и зелен лук.",
                    Price = 30.50M,
                    ImageUrl = "https://dostavka.happy.bg/remote/files/images/27142/fit_640_400.png?rev=1643806171"


                },
                new Dish()
                {
                    Id = 5,
                    Title = "Аржентински котлет",
                    Ingredients= "Свински котлет в специална марината, печени картофи, чимичури и пимиентос де падрон.",
                    Price = 30.99M,
                    ImageUrl = "https://dostavka.happy.bg/remote/files/images/228302/fit_640_400.png?rev=1697363605"

                },
                 new Dish()
                {
                    Id = 6,
                    Title = "Екстра Суши Комбо 48 БР",
                    Ingredients= "Хосомаки краставица 16 бр., Филаделфия сьомга, авокадо и хрупкава темпура 8 бр., Норвежка гора 8 бр.,  Филаделфия пушена сьомга 8 бр., Филаделфия хрупкаво пиле 8 бр.",
                    Price = 50.50M,
                    ImageUrl = "https://dostavka.happy.bg/remote/files/images/6981/fit_640_400.png?rev=1637069133"

                },
                  new Dish()
                {
                    Id = 7,
                    Title = "Макси Чикън 30 БР",
                    Ingredients= "Чикън Везувий 8 бр., Чикън Кинг 6 бр., Клуб Чикън 4 бр., Дракон пиле 4 бр., Трюфел пиле 8 бр.",
                    Price = 30.99M,
                    ImageUrl = "https://dostavka.happy.bg/remote/files/images/120941/fit_640_400.png?rev=1675441077"

                },
                   new Dish()
                {
                    Id = 8,
                    Title = "Бурж Ал Араб 14 БР",
                    Ingredients= "Футомаки хрупкаво пиле с Филаделфия и амарант 6 бр., Филаделфия сьомга, авокадо и хрупкава темпура 4 бр., Емирейтс рол с манго и Филаделфия 4 бр., Хепи майонеза, унаги сос и ядлива златна пудра.",
                    Price = 20.50M,
                    ImageUrl = "https://dostavka.happy.bg/remote/files/images/116440/fit_640_400.png?rev=1674131382"

                },
                     new Dish()
                {
                    Id = 9,
                    Title = "Суфле С Течен Център Шоколад",
                    Ingredients= "Суфле с течен център от шоколад.",
                    Price = 7.90M,
                    ImageUrl = "https://dostavka.happy.bg/remote/files/images/3882/fit_640_400.png?rev=1626000157"

                },
                        new Dish()
                {
                    Id = 10,
                    Title = "Нутела С Ягоди И Маскарпоне",
                    Ingredients= "Хрупкав бисквитен блат, маскарпоне крем, сладко от ягоди и шоколад.",
                    Price = 8.00M,
                    ImageUrl = "https://dostavka.happy.bg/remote/files/images/353328/fit_640_400.png?rev=1707735140"

                },


       };
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
    
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<HouseRentingSystem.Data.Entities.Dish>().HasData(dishes);
            base.OnModelCreating(builder);
        }
    }

}
