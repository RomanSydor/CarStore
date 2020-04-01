using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarStore.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string Name { get; set; }
    }
}