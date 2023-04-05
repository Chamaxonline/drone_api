using Entity.Context;
using Entity.Models;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Implementation
{
    public class MedicationRepository: EfRepository<Medication>, IMedicationRepository
    {
        protected DroneDbContext _context;
        public MedicationRepository(DroneDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
