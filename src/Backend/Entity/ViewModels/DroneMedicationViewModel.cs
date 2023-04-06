using Entity.Mappings;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.ViewModels
{
    public class DroneMedicationViewModel : IMapBoth<DroneMedication>
    {
        public int? Id { get; set; }
        public int DroneId { get; set; }
        public int MedicationId { get; set; }
        public int MedicationQty { get; set; }
        public decimal TotalWeight { get; set; }
        public bool Active { get; set; }
    }
}
