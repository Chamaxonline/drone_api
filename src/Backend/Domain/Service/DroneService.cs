﻿using AutoMapper;
using Domain.Service.Interface;
using Entity.Models;
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
           return await _droneRepository.Add(drone);
           
        }
    }
}