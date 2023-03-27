using ClassRepository.IRepository;
using ClassRepository.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRepository.Repository
{
    public  class RestaurantRepository : IRestaurantRepository
    {
        private readonly ModelBuilder _modelBuilder;
        public RestaurantRepository(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
           
          
        }
        public void Seed()
        {
            SeedCuisines();
            SeedRestaurants();
        }
        private void SeedRestaurants()
        {
            _modelBuilder.Entity<Restaurant>().HasData(
                 new Restaurant() { Id = 1, Name = "Liverfool", Description = "We sell delicious fool" , CuisineId = 1},
                new Restaurant() { Id = 2, Name = "Pizza Palace", Description = "Authentic Italian pizzas made fresh daily", CuisineId = 1 },
                new Restaurant() { Id = 3, Name = "Burger Barn", Description = "Juicy burgers and crispy fries", CuisineId = 1 },
                new Restaurant() { Id = 4, Name = "Sushi Spot", Description = "Fresh sushi rolls and sashimi", CuisineId = 1 },
                new Restaurant() { Id = 5, Name = "Taco Town", Description = "Authentic Mexican tacos and burritos" , CuisineId = 1 },
                new Restaurant() { Id = 6, Name = "Curry House", Description = "Spicy and flavorful Indian curries", CuisineId = 1 },
                new Restaurant() { Id = 7, Name = "Thai Terrace", Description = "Authentic Thai cuisine with a view" , CuisineId = 1 },
                new Restaurant() { Id = 8, Name = "Steakhouse", Description = "Juicy steaks cooked to perfection" , CuisineId = 1 },
                new Restaurant() { Id = 9, Name = "Ramen Rave", Description = "Satisfying bowls of ramen noodles", CuisineId = 1 },
                new Restaurant() { Id = 10, Name = "Seafood Shack", Description = "Fresh seafood and shellfish dishes", CuisineId = 1 }

                );

        }
        private void SeedCuisines()
        {
            _modelBuilder.Entity<Cuisine>().HasData(
            new Cuisine
            {
                CuisineId = 1,
                Name = "Italian"
            },
            new Cuisine
            {
                CuisineId = 2,
                Name = "French"
            },
            new Cuisine
            {
                CuisineId = 3,
                Name = "Japanese"
            }
            );
        }
    }
}
