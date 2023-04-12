using Common;
using Domain.Service.Interface;
using Entity.Models;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    public class DroneMedicationService : IDroneMedicationService
    {
        private readonly IDroneMedicationRepository _droneMedicationRepository;
        private readonly IDroneRepository _droneRepository;
        public DroneMedicationService(IDroneMedicationRepository droneMedicationRepository, IDroneRepository droneRepository)
        {
            _droneMedicationRepository = droneMedicationRepository;
            _droneRepository = droneRepository;
        }

        public async Task<DroneMedication> Add(DroneMedication droneMedication)
        {
            return await _droneMedicationRepository.Add(droneMedication);
        }

        public async Task<string> LoadingValidation(DroneMedication droneMedication)
        {
            string status = string.Empty;
            var drone = await _droneRepository.GetById(droneMedication.DroneId);

            //Prevent the drone from being loaded with more weight that it can carry;
            //Prevent the drone from being in LOADING state if the battery level is below 25%; 
            if (drone.WeightLimit < droneMedication.TotalWeight)
            {
              return  Utilities.droneWeightExceed;
            }
            if(Convert.ToDouble(drone.BatteryCapacity) < Utilities.minimumBattryCapacity)
            {
                return Utilities.droneBatteryLevel;
            }
            return status;

        }

        public async Task<List<DroneMedication>> GetByDroneId(int droneId)
        {
           return await _droneMedicationRepository.GetByDroneId(droneId);
        }
       

    }
}
