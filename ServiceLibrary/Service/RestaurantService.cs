using ClassRepository.IRepository;
using ClassRepository.Model;
using ServiceLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary.Service
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IRestaurantRepository _repository;

        public RestaurantService(IRestaurantRepository repository)
        {
            _repository = repository;
        }

        public void Create(Restaurant restaurant)
        {
            restaurant.Id = _repository.Restaurants.Max(x => x.Id)+1;
            _repository.Restaurants.Add(restaurant);
        }

        public bool Delete(int id)
        {
            var deletedrestaurant = GetRestaurant(id);
            if(deletedrestaurant != null)
            {
                _repository.Restaurants.Remove(deletedrestaurant);
                return true;
            }
            return false;
        }

        public Restaurant GetRestaurant(int id)
        {
            return _repository.Restaurants.FirstOrDefault(x => x.Id == id);
        }

        public List<Restaurant> GetRestaurants()
        {
            return _repository.Restaurants.ToList();
        }

        public bool Update(Restaurant restaurant)
        {
            var restaurantupdated = GetRestaurant(restaurant.Id);
            if (restaurantupdated != null)
            {
                restaurantupdated.Name = restaurant.Name;
                restaurantupdated.Description = restaurant.Description;
                _repository.Restaurants.Add(restaurantupdated);
                return true;
            }
            return false;
        }

    }
}
