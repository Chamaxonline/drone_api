using Domain.Service.Interface;
using Entity.Models;
using Entity.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/drones")]
    [ApiController]
    public class DroneController : ApiController
    {
        private readonly IDroneService _droneService;
        private readonly IDroneMedicationService _droneMedicationService;
        public DroneController(IDroneService droneService, IDroneMedicationService droneMedicationService)
        {
            _droneService = droneService;
            _droneMedicationService = droneMedicationService;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<ActionResult> Register(DroneViewModel viewModel)
        {
            try
            {
                var drone = Mapper.Map<Drone>(viewModel);
                var result = await _droneService.Create(drone);
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }

        }

        [HttpPost]
        [Route("LoadDrone")]
        public async Task<ActionResult> LoadDrone(DroneMedicationViewModel viewModel)
        {
            try
            {
                var droneMedication = Mapper.Map<DroneMedication>(viewModel);
                var droneValidity = await _droneMedicationService.LoadingValidation(droneMedication);
                if (droneValidity.Length == 0)
                {
                    var result = await _droneMedicationService.Add(droneMedication);
                    return Ok(result);
                }
                else
                {
                    return Ok(droneValidity);
                }

            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }

        [HttpGet]
        [Route("BatteryLevel/{Id}")]
        public async Task<ActionResult> BatteryLevel(int id)
        {
            var drone = await _droneService.Get(id);
            return Ok(drone.BatteryCapacity);
        }

        [HttpGet]
        [Route("LoadedMedicationItems/{droneId}")]
        public async Task<ActionResult> LoadedMedicationItems(int droneId)
        {
            var items = await _droneMedicationService.GetByDroneId(droneId);
            return Ok(items);
        }

    }
}
