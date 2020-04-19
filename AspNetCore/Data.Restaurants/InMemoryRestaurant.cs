using System.Collections.Generic;
using System.Linq;
using Models.Restaurants;

namespace Data.Restaurants
{
    public class InMemoryRestaurant: IRestaurant
    {
        private List<Restaurant> restaurants;
        public InMemoryRestaurant()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant(){Id = 1, CuisineType = CuisineType.Mexican, Name = "Hot potato", Location = "Mexico"},
                new Restaurant(){Id = 2, CuisineType =  CuisineType.Indian, Name = "Mustafa", Location = "Deli"},
                new Restaurant(){Id = 3, CuisineType = CuisineType.Italian, Name = "Pizza", Location = "Rome"}
            };
        }
        public IEnumerable<Restaurant> GetRastaurantsByName(string name = null)
        {
            return from r in restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                orderby r.Name
                select r;
        }

        public Restaurant GetById(int id)
        {
            return restaurants.SingleOrDefault(e => e.Id == id);
        }
    }
}
