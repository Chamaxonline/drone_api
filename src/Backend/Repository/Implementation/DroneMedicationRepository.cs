using Entity.Context;
using Entity.Models;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Implementation
{
    public class DroneMedicationRepository : EfRepository<DroneMedication>, IDroneMedicationRepository
    {
        protected DroneDbContext _context;
        public DroneMedicationRepository(DroneDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
