using SonDers_JWToken.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonDers_JWToken.Business.Interfaces
{
    public interface ICarService
    {
        Task<IEnumerable<Car>> GetCars();
    }
}
