using CarStore.Models;
using System;

namespace CarStore.Services
{
    public class PurchaseService : IPurchaseService
    {
        CarStoreContext db = new CarStoreContext();
        IIdSaverService _idSaver;

        Purchase _purchase;

        public PurchaseService(IIdSaverService ids) 
        {
            _idSaver = ids;
        }

        public void BrandChoose()
        {
            var id = _idSaver.AllIds();
            if (_purchase == null)
            {
                _purchase = new Purchase();
            }
            _purchase.Price = 0;
           _purchase.BrandId = id.SavedBrandId;
        }

        public void CarTypeChoose() 
        {
            var id = _idSaver.AllIds().SavedCarTypeId;
            if (_purchase == null)
            {
                _purchase = new Purchase();
            }
            _purchase.Price = 0;
            _purchase.CarTypeId = id;
        }

        public void CarColorChoose()
        {
            var id = _idSaver.AllIds().SavedCarColorId;
            CarColor carColor;
            if (_purchase == null)
            {
                _purchase = new Purchase();
            }
            carColor = db.CarColors.Find(id);
            _purchase.Price += carColor.Price;
            _purchase.CarColorId = id;
        }

        public void CarModelChoose()
        {
            var id = _idSaver.AllIds().SavedCarModelId;
            if (_purchase == null)
            {
                _purchase = new Purchase();
            }
            _purchase.Price = 0;
            _purchase.CarModelId = id;
        }

        public void ConfigChoose()
        {
            var id = _idSaver.AllIds().SavedConfigId;
            Config config;
            if (_purchase == null)
            {
                _purchase = new Purchase();
            }
            config = db.Configs.Find(id);
            _purchase.Price += config.Price;
            _purchase.ConfigId = id;
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