﻿using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    public interface IMedicationRepository: IAsyncRepository<Medication>
    {
    }
}
