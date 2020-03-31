using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarStore.Services
{
    public class PurchaseService : IPurchaseService
    {
        public static int BrandId{ get; set; }
        public static int CarModelId { get; set; }
        public static int ConfigId { get; set; }
        public static int CarColorId { get; set; }

        public void ChooseBrand(int? id)
        {
            BrandId = id.Value;
        }

        public void ChooseCarColor(int? id)
        {
            CarColorId = id.Value;
        }

        public void ChooseCarModel(int? id)
        {
            CarModelId = id.Value;
        }

        public void ChooseConfig(int? id)
        {
            ConfigId = id.Value;
        }
    }
}