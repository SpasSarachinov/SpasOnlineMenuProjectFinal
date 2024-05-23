using HouseRentingSystem.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using SpasOnlineMenuProjectFinal.Data;
using SpasOnlineMenuProjectFinal.Models;

namespace HouseRentingSystem.Controllers
{
    public class MenuController : Controller
    {
        private ApplicationDbContext context;
        private static decimal v;

        public MenuController(ApplicationDbContext ctx)
        {
            context = ctx;
            this.context = context;
        }
        //private List<Dish> dishes
        //    = new List<Dish>
        //{
        //    new Dish()
        //    {
        //        Id=1,
        //        Title = "Яйца Бенедеикт",
        //        Ingridients = "яйца,питка, тънки резени бекон, магданоз,лимонов сок",
        //        Price = 18M,
        //       ImageUrl = "https://assets-eu-01.kc-usercontent.com/00b9925d-7322-014e-f702-6ef9aa1a28b4/f509cc3f-85ee-4f27-bd60-1384807311b5/01072018-293.jpg?w=1200&fm=webp&lossless=0&q=80"
        //    },
        //      new Dish()
        //    {
        //         Id = 2,
        //        Title = "Бъркани яйца",
        //        Ingridients = "яйца, черен пипер, сметана",
        //        ImageUrl = "https://media-cldnry.s-nbcnews.com/image/upload/t_social_share_1200x630_center,f_auto,q_auto:best/newscms/2020_04/1530595/fluffy-scrambled-eggs-today-main-200121-2.jpg"
        //    },
        //        new Dish()
        //    {
        //            Id = 3,
        //        Title = "Телешки стек",
        //        Ingridients = "Телешки стек с чимичури сос, чушки пимиентос де падрон и пюре от сладък картоф",
        //        ImageUrl = "https://dostavka.happy.bg/remote/files/images/215620/fit_640_400.png?rev=1697484896"
        //    },
        //        new Dish()
        //        {
        //            Id = 4,
        //            Title = "Ребра Иберико По Азиатски",
        //            Ingridients = "Свински ребра с азиатски барбекю сос, кашу и зелен лук.",
        //            ImageUrl = "https://dostavka.happy.bg/remote/files/images/27142/fit_640_400.png?rev=1643806171"


        //        },
        //        new Dish()
        //        {
        //            Id = 5,
        //            Title = "Аржентински котлет",
        //            Ingridients= "Свински котлет в специална марината, печени картофи, чимичури и пимиентос де падрон.",
        //            ImageUrl = "https://dostavka.happy.bg/remote/files/images/228302/fit_640_400.png?rev=1697363605"

        //        },
        //         new Dish()
        //        {
        //            Id = 6,
        //            Title = "Екстра Суши Комбо 48 БР",
        //            Ingridients= "Хосомаки краставица 16 бр., Филаделфия сьомга, авокадо и хрупкава темпура 8 бр., Норвежка гора 8 бр.,  Филаделфия пушена сьомга 8 бр., Филаделфия хрупкаво пиле 8 бр.",
        //            ImageUrl = "https://dostavka.happy.bg/remote/files/images/6981/fit_640_400.png?rev=1637069133"

        //        },
        //          new Dish()
        //        {
        //            Id = 7,
        //            Title = "Макси Чикън 30 БР",
        //            Ingridients= "Чикън Везувий 8 бр., Чикън Кинг 6 бр., Клуб Чикън 4 бр., Дракон пиле 4 бр., Трюфел пиле 8 бр.",
        //            ImageUrl = "https://dostavka.happy.bg/remote/files/images/120941/fit_640_400.png?rev=1675441077"

        //        },
        //           new Dish()
        //        {
        //            Id = 8,
        //            Title = "Бурж Ал Араб 14 БР",
        //            Ingridients= "Футомаки хрупкаво пиле с Филаделфия и амарант 6 бр., Филаделфия сьомга, авокадо и хрупкава темпура 4 бр., Емирейтс рол с манго и Филаделфия 4 бр., Хепи майонеза, унаги сос и ядлива златна пудра.",
        //            ImageUrl = "https://dostavka.happy.bg/remote/files/images/116440/fit_640_400.png?rev=1674131382"

        //        },
        //             new Dish()
        //        {
        //            Id = 9,
        //            Title = "Суфле С Течен Център Шоколад",
        //            Ingridients= "Суфле с течен център от шоколад.",
        //            ImageUrl = "https://dostavka.happy.bg/remote/files/images/3882/fit_640_400.png?rev=1626000157"

        //        },
        //                new Dish()
        //        {
        //            Id = 10,
        //            Title = "Нутела С Ягоди И Маскарпоне",
        //            Ingridients= "Хрупкав бисквитен блат, маскарпоне крем, сладко от ягоди и шоколад.",
        //            ImageUrl = "https://dostavka.happy.bg/remote/files/images/353328/fit_640_400.png?rev=1707735140"

        //        },


        //};
        public IActionResult All()
        {
            var menu = this.context.Dishes
                .Where(d => d.IsDeleted == false)
                .Select(d => new MenuDetailVewModel
                {
                    Id = d.Id,
                    Title = d.Title,
                    Ingridients = d.Ingredients,
                    Price = d.Price,
                    ImageUrl = d.ImageUrl,
                }).ToList();

            return View(menu);
        }
        public IActionResult MenuDetails(int id)
        {
            var model = context.Dishes.Where(h => h.Id == id)
                               .Select(d => new MenuDetailVewModel
                               {
                                   Id = d.Id,
                                   Title = d.Title,
                                   Ingridients = d.Ingredients,
                                   Price = d.Price,
                                   ImageUrl = d.ImageUrl,
                               }).FirstOrDefault();
            if (model == null)
            {
                return BadRequest();
            }

            return View(model);
        }
        [HttpGet]
        public IActionResult Add()
        {
            var model = new DishFormModel();


            return View(model);
        }
        [HttpPost]
        public IActionResult Add(DishFormModel model)
        {
            if (ModelState.IsValid == false)
            {
                return View(model);
            }
            var Dish = new Dish()
            {
                Ingredients = model.Ingredients,
                Price = model.Price,
                ImageUrl = model.ImageUrl,
                Title = model.Title,
            };
            context.Dishes.Add(Dish);
            context.SaveChanges();
            return RedirectToAction(nameof(All));
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var dish = context.Dishes.Find(id);
            var model1 = new DishFormModel()
            {
                Id = id,
                Ingredients = dish.Ingredients,
                Price = dish.Price,
                ImageUrl = dish.ImageUrl,
                Title = dish.Title,

            };

            return View(model1);
        }


        [HttpPost]
        public IActionResult Edit(int id, DishFormModel model)
        {
            if (ModelState.IsValid == false)
            {
                return View(model);
            }

            var dish = context.Dishes.Find(id);

            dish.Ingredients = model.Ingredients;
            dish.Price = model.Price;
            dish.ImageUrl = model.ImageUrl;
            dish.Title = model.Title;


            context.SaveChanges();

            return RedirectToAction(nameof(All));

        }
        public IActionResult Delete(int id)
        {
            var dish = context.Dishes.Find(id);
            dish.IsDeleted = true;
            context.SaveChanges();
            return RedirectToAction(nameof(All));
        }
    }
}

