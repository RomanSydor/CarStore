using CarStore.Models;
using System;

namespace CarStore.Services
{
    public class PurchaseService : IPurchaseService
    {
        CarStoreContext db = new CarStoreContext();
        Purchase _purchase;

        public void BrandChoose(int? id)
        {
            if (_purchase == null)
            {
                _purchase = new Purchase();
            }
            _purchase.Price = 0;
           _purchase.BrandId = id.Value;
        }

        public void CarTypeChoose(int? id)
        {
            if (_purchase == null)
            {
                _purchase = new Purchase();
            }
            _purchase.Price = 0;
            _purchase.CarTypeId = id.Value;
        }

        public void CarColorChoose(int? id)
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

        public void CarColorCancel(int? id)
        {
            CarColor carColor;
            if (_purchase == null)
            {
                _purchase = new Purchase();
            }
            carColor = db.CarColors.Find(id);
            _purchase.Price -= carColor.Price;
            _purchase.CarColorId = 0;
        }

        public void CarModelChoose(int? id)
        {
            if (_purchase == null)
            {
                _purchase = new Purchase();
            }
            _purchase.Price = 0;
            _purchase.CarModelId = id.Value;
        }

        public void ConfigChoose(int? id)
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

        public void ConfigCancel(int? id) 
        {
            Config config;
            if (_purchase == null)
            {
                _purchase = new Purchase();
            }
            config = db.Configs.Find(id);
            _purchase.Price -= config.Price;
            _purchase.ConfigId = 0;
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