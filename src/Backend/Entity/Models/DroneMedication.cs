using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.Models
{
    public class DroneMedication: BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public int DroneId { get; set; }
        public int MedicationId { get; set; }
        public int MedicationQty { get; set; }
        public decimal TotalWeight { get; set; }
        public bool Active { get; set; }

    }
}
