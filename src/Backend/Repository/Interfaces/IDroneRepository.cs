using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IDroneRepository : IAsyncRepository<Drone>
    {
        Task<List<Drone>> AvailableDrones();
    }
}
