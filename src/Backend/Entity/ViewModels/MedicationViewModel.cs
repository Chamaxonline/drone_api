using Entity.Mappings;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.ViewModels
{
    public class MedicationViewModel: IMapBoth<Medication>
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public string Code { get; set; }
        public string Image { get; set; }
    }
}
