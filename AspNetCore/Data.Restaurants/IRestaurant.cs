using System.Collections.Generic;
using Models.Restaurants;

namespace Data.Restaurants
{
    public interface IRestaurant
    {
        IEnumerable<Restaurant> GetAll();
    }
}
