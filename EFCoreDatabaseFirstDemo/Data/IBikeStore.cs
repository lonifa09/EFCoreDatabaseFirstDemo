using EFCoreDatabaseFirstDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreDatabaseFirstDemo.Data
{
    public interface IBikeStore
    {
        Task<IEnumerable<Brand>> GetBrands();
    }
}
