using EFCoreDatabaseFirstDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreDatabaseFirstDemo.Data
{
    public class BikeStoreSql : IBikeStore
    {
        private BikeStoresContext BikeStoresContext { get; }
        public BikeStoreSql(BikeStoresContext bikeStoresContext)
        {
            BikeStoresContext = bikeStoresContext;
        }

        public async Task<IEnumerable<Brand>> GetBrands()
        {
            return await BikeStoresContext.Brands.ToListAsync();
        }
    }
}
