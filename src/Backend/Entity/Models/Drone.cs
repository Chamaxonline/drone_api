using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public decimal BatteryCapacity { get; set; }
        public DroneStateEnum State { get; set; }
    }
}
