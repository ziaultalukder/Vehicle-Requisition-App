﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementApp.Models.Models;

namespace VehicleManagementApp.BLL.Contracts
{
    public interface IDesignationManager:IManager<Designation>
    {
        bool IsNameAlreadyExist(string name);
        bool IsNameUnique(string name,int departmentId);
    }
}
