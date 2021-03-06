﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementApp.Models.Models;

namespace VehicleManagementApp.BLL.Contracts
{
    public interface IEmployeeManager:IManager<Employee>
    {
        bool IsContactAlreadyExist(string contactNo);
        bool IsEmailAlreadyExist(string email);
        bool IsLicenceAlreadyExist(string licenceNo);
    }
}
