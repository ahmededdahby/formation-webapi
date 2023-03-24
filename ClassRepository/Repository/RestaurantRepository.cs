using ClassRepository.IRepository;
using ClassRepository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRepository.Repository
{
    public  class RestaurantRepository : IRestaurantRepository
    {
        public  List<Restaurant> Restaurants { get; set; }
        public RestaurantRepository()
        {
            Restaurants = new List<Restaurant>()
            {
                new Restaurant() { Id = 1, Name = "Liverfool", Description = "We sell delicious fool" },
                new Restaurant() { Id = 2, Name = "Pizza Palace", Description = "Authentic Italian pizzas made fresh daily" },
                new Restaurant() { Id = 3, Name = "Burger Barn", Description = "Juicy burgers and crispy fries" },
                new Restaurant() { Id = 4, Name = "Sushi Spot", Description = "Fresh sushi rolls and sashimi" },
                new Restaurant() { Id = 5, Name = "Taco Town", Description = "Authentic Mexican tacos and burritos" },
                new Restaurant() { Id = 6, Name = "Curry House", Description = "Spicy and flavorful Indian curries" },
                new Restaurant() { Id = 7, Name = "Thai Terrace",Description = "Authentic Thai cuisine with a view" },
                new Restaurant() { Id = 8, Name = "Steakhouse", Description = "Juicy steaks cooked to perfection" },
                new Restaurant() { Id = 9, Name = "Ramen Rave", Description = "Satisfying bowls of ramen noodles" },
                new Restaurant() { Id = 10, Name = "Seafood Shack", Description = "Fresh seafood and shellfish dishes" }

            };
        }
    }
}
