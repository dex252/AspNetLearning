using System.Collections.Generic;
using Data.Restaurants;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Models.Restaurants;

namespace Web.Restaurants.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        private readonly IRestaurant restaurantData;
        public IConfiguration config { get; set; }
        public string Message { get; set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }
        public ListModel(IConfiguration config, IRestaurant restaurantData)
        {
            this.restaurantData = restaurantData;
            this.config = config;
            Message = config["Message"];
        }
        public void OnGet()
        {
            Restaurants = restaurantData.GetRastaurantsByName(SearchTerm);
        }
    }
}
