using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarStore.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public string Phone { get; set; }
        public DateTime Date { get; set; }
        public int BrandId { get; set; }
        public int CarModelId { get; set; }
        public int ConfigId { get; set; }
        public int CarColorId { get; set; }

    }
}