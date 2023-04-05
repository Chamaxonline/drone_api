using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Interface
{
    public interface IDroneService
    {
        Task<Drone> Create(Drone drone);
    }
}
