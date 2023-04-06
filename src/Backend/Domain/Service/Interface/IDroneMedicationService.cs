using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Interface
{
    public interface IDroneMedicationService
    {
        Task<DroneMedication> Add(DroneMedication droneMedication);
        Task<string> LoadingValidation(DroneMedication droneMedication);
    }
}
