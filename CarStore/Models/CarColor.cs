﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarStore.Models
{
    public class CarColor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RGBCode { get; set; }
        public float Price { get; set; }
    }
}