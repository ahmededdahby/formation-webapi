using ClassRepository.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary.Abstract
{
    public interface IRestaurantService
    {
        Task AddRestaurantAsync(Restaurant restaurant);
        Task DeleteRestaurantAsync(int id);
        Task<Restaurant?> GetRestaurantAsync(int id);
        Task<IEnumerable<Restaurant>> GetRestaurantsAsync();
        Task UpdateRestaurantAsync(Restaurant restaurant);
    }
}
