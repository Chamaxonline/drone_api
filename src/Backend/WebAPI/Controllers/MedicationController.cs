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
    [Route("api/medications")]
    [ApiController]
    public class MedicationController : ApiController
    {
        private readonly IMedicationService _medicationService;
        public MedicationController(IMedicationService medicationService)
        {
            _medicationService = medicationService;
        }

        [HttpPost]
        [Route("Register")]
        //api/medications/Register
        public async Task<ActionResult> Register(MedicationViewModel viewModel)
        {
            try
            {
                var medication = Mapper.Map<Medication>(viewModel);
                var result = await _medicationService.Create(medication);
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }

        }
    }
}
