﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementApp.BLL.Base;
using VehicleManagementApp.BLL.Contracts;
using VehicleManagementApp.Models.Models;
using VehicleManagementApp.Repository;
using VehicleManagementApp.Repository.Contracts;
using VehicleManagementApp.Repository.Repository;

namespace VehicleManagementApp.BLL
{
    public class DriverStatusManager:Manager<DriverStatus>, IDriverStatusManager
    {
        private IDriverStatusRepository driverStatusRepository;

        public DriverStatusManager() : base(new DriverStatusRepository())
        {
            this.driverStatusRepository = (DriverStatusRepository)base.BaseRepository;
        }
        public DriverStatusManager(IDriverStatusRepository Repository) : base(Repository)
        {
            this.driverStatusRepository = Repository;
        }

       

       
    }
}
