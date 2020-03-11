using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarStore.Models
{
    public class Config
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CarModelId { get; set; }
        public string Transmission { get; set; }
        public string EngineType { get; set; }
        public float EngineVolume { get; set; }
        public int WheelSize { get; set; }
    }
}