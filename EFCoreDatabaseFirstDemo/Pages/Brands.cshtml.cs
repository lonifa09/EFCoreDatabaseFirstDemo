using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreDatabaseFirstDemo.Data;
using EFCoreDatabaseFirstDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFCoreDatabaseFirstDemo.Pages
{
    public class BrandsModel : PageModel
    {
        public List<Brand> Brands;
        private IBikeStore BikeStore { get; }
        public BrandsModel(IBikeStore bikeStore)
        {
            BikeStore = bikeStore;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var brands = await BikeStore.GetBrands();
            Brands = brands.ToList();
            return Page();
        }
    }
}
