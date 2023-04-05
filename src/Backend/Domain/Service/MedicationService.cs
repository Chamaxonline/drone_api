using Domain.Service.Interface;
using Entity.Models;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    public class MedicationService:IMedicationService
    {
        private readonly IMedicationRepository _medicationRepository;

        public MedicationService(IMedicationRepository medicationRepository)
        {
            _medicationRepository = medicationRepository;
        }
        public async Task<Medication> Create(Medication medication)
        {
            return await _medicationRepository.Add(medication);

        }
    }
}
