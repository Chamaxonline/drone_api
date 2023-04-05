using Common.Enum;
using Entity.Mappings;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.ViewModels
{
    public class DroneViewModel: IMapBoth<Drone>
    {
        public int? Id { get; set; }
        public string SerialNumber { get; set; }
        public DroneModelEnum Model { get; set; }
        public Decimal BatteryCapacity { get; set; }
        public DroneStateEnum State { get; set; }
    }
}
