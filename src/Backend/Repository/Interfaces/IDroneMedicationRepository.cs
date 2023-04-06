using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IDroneMedicationRepository: IAsyncRepository<DroneMedication>
    {
        Task<List<DroneMedication>> GetByDroneId(int droneId);
    }
}
