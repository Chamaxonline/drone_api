using Entity.Context;
using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class DroneMedicationRepository : EfRepository<DroneMedication>, IDroneMedicationRepository
    {
        protected DroneDbContext _context;
        public DroneMedicationRepository(DroneDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<DroneMedication>>GetByDroneId (int droneId)
        {
            return await _context.DroneMedication.Where(x => x.DroneId == droneId).ToListAsync();
        }
    }
}
