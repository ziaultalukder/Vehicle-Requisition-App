﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VehicleManagementApp.ViewModels
{
    public class DivisionViewModel
    {
        public int Id { get; set; }

        [Required]
        [Remote("IsNameExist", "Division", HttpMethod = "POST", ErrorMessage = "Division Already Exist, Try Another")]
        [Display(Name = "Division Name")]
        public string Name { get; set; }
    }
}