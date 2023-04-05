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
        public DroneController(IDroneService droneService)
        {
            _droneService = droneService;
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
    }
}
