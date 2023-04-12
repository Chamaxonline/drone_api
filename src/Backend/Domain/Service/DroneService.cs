using AutoMapper;
using Domain.Service.Interface;
using Entity.Models;
using Entity.ViewModels;
using Microsoft.AspNetCore.Http;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    public class DroneService : Profile, IDroneService
    {
        private readonly IDroneRepository _droneRepository;
        public DroneService(IDroneRepository droneRepository)
        {
            _droneRepository = droneRepository;
        }

        public async Task<Drone> Create(Drone drone)
        {
            drone.SerialNumber = GenerateSerialNumber();
            return await _droneRepository.Add(drone);

        }
        public async Task<Drone> Get(int id)
        {
            return await _droneRepository.GetById(id);
        }

        public async Task<List<Drone>> GetAvailableDrones()
        {
            return await _droneRepository.AvailableDrones();
        }
        public async Task<decimal> ConvertStringtoPrecentage(string percentage)
        {
            return await Task.FromResult(decimal.Parse(percentage.Replace("%", "")) / 100);
        }

        public async Task<Drone> UpdateStatus(int droneId, int status)
        {
            var drone = await _droneRepository.GetById(droneId);
            drone.State = (Common.Enum.DroneStateEnum)status;
            return await _droneRepository.Update(drone);
        }
        private string GenerateSerialNumber()
        {
            var serialNumber = Guid.NewGuid();
            if (serialNumber.ToString().Length > 100)
            {
                return serialNumber.ToString().Substring(0, 100);
            }

            return serialNumber.ToString();
        }

        
    }
}
