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
    public class DroneService : Profile,IDroneService
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
        
        private string GenerateSerialNumber()
        {
            Guid serialNumber = Guid.NewGuid();
           return serialNumber.ToString();
        }        
    }
}
