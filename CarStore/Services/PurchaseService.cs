using CarStore.Models;
using System;

namespace CarStore.Services
{
    public class PurchaseService : IPurchaseService
    {
        CarStoreContext db = new CarStoreContext();
        Purchase _purchase;

        public void ChooseBrand(int? id)
        {
            if (_purchase == null)
            {
                _purchase = new Purchase();
            }
            _purchase.Price = 0;
           _purchase.BrandId = id.Value;
        }

        public void ChooseCarType(int? id)
        {
            if (_purchase == null)
            {
                _purchase = new Purchase();
            }
            _purchase.Price = 0;
            _purchase.CarTypeId = id.Value;
        }

        public void ChooseCarColor(int? id)
        {
            CarColor carColor;
            if (_purchase == null)
            {
                _purchase = new Purchase();
            }
            carColor = db.CarColors.Find(id);
            _purchase.Price += carColor.Price;
            _purchase.CarColorId = id.Value;
        }

        public void ChooseCarModel(int? id)
        {
            if (_purchase == null)
            {
                _purchase = new Purchase();
            }
            _purchase.Price = 0;
            _purchase.CarModelId = id.Value;
        }

        public void ChooseConfig(int? id)
        {
            Config config;
            if (_purchase == null)
            {
                _purchase = new Purchase();
            }
            config = db.Configs.Find(id);
            _purchase.Price += config.Price;
            _purchase.ConfigId = id.Value;
        }

        public Purchase Create()
        {
            if (_purchase == null)
            {
                _purchase = new Purchase();
            }
            _purchase.Date = DateTime.Now;
            return _purchase;
        }
    }
}