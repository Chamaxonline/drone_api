using Entity.Context;
using Entity.Models;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class DroneRepository: EfRepository<Drone> , IDroneRepository
    {
        protected DroneDbContext _context;
        public DroneRepository(DroneDbContext context) :base(context)
        {
            _context = context;
        }


    }
}
