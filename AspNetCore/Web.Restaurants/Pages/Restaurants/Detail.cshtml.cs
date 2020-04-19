using Data.Restaurants;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models.Restaurants;

namespace Web.Restaurants
{
    public class DetailModel : PageModel
    {
        private readonly IRestaurant restaurantData;
        public Restaurant Restaurant { get; set; }

        public DetailModel(IRestaurant restaurantData)
        {
            this.restaurantData = restaurantData;
        }
        public IActionResult OnGet(int restaurantId)
        {
            Restaurant = restaurantData.GetById(restaurantId);
            if (Restaurant == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}