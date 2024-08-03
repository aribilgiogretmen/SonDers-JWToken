using Microsoft.EntityFrameworkCore;
using SonDers_JWToken.Business.Interfaces;
using SonDers_JWToken.DataAccess;
using SonDers_JWToken.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonDers_JWToken.Business.Services
{
    public class CarService : ICarService
    {

        private readonly ApplicationDbContext _context;

        public CarService(ApplicationDbContext context)
        {
            _context= context;
        }

        public async Task<IEnumerable<Car>> GetCars()
        {
            return await _context.Car.Include(x=>x.Model).ThenInclude(m=>m.Brand).ToListAsync();
        }
    }
}
