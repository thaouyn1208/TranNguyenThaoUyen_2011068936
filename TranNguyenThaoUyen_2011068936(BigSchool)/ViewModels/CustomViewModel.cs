﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TranNguyenThaoUyen_2011068936_BigSchool_.ViewModels
{
    public class CustomViewModel
    {
        public class CourseViewModel
        {
            [Required]
            public string Place { get; set; }
            [Required]
            [FutureDate]
            public string Date { get; set; }
            [Required]
            [ValidTime]
            public string Time { get; set; }
        }
    }
}