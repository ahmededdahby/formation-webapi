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
        List<Restaurant> GetRestaurants();
        Restaurant GetRestaurant(int id);

        Boolean Update(Restaurant restaurant);

        void Create(Restaurant restaurant);

        bool Delete(int id);
    }
}
