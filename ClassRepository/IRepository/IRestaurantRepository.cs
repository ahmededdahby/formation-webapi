using ClassRepository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRepository.IRepository
{
    public  interface IRestaurantRepository
    {
        

        List<Restaurant> Restaurants { get; set; }
    }
}
