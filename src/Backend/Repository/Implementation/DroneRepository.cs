using Common.Enum;
using Entity.Context;
using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<List<Drone>> AvailableDrones()
        {
          return  await _context.Drone.Where(x => x.State == (int)DroneStateEnum.IDLE).ToListAsync();
        }
    }
}
