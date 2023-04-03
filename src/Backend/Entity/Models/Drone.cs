using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity.Models
{
    public class Drone
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string SerialNumber { get; set; }
        public DroneModelEnum Model { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public Decimal BatteryCapacity { get; set; }
        public DroneStateEnum State { get; set; }
    }
}
