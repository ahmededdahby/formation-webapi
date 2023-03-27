using ClassRepository.IRepository;
using ClassRepository.Model;
using ClassRepository.Repository;
using Microsoft.EntityFrameworkCore;
using ServiceLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary.Service
{
    public class RestaurantService : IRestaurantService {
        private readonly AppDbContext _context;

        public RestaurantService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Restaurant>> GetRestaurantsAsync()
        {
            return await _context.Restaurants.Include(r => r.Cuisine).ToListAsync();
        }

        public async Task<Restaurant?> GetRestaurantAsync(int id)
        {
            return await _context.Restaurants.Include(r => r.Cuisine).FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task AddRestaurantAsync(Restaurant restaurant)
        {
            await _context.Restaurants.AddAsync(restaurant);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateRestaurantAsync(Restaurant restaurant)
        {
            _context.Entry(restaurant).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRestaurantAsync(int id)
        {
            var restaurant = await _context.Restaurants.FindAsync(id);
            if (restaurant is null)
                return;

            _context.Restaurants.Remove(restaurant);
            await _context.SaveChangesAsync();
        }

    }
}
