using CarStore.Models;
using System;

namespace CarStore.Services
{
    public class PurchaseService : IPurchaseService
    {
        Purchase _purchase;

        public void ChooseBrand(int? id)
        {
            if (_purchase == null)
            {
                _purchase = new Purchase();
            }
           _purchase.BrandId = id.Value;
        }

        public void ChooseCarColor(int? id)
        {
            if (_purchase == null)
            {
                _purchase = new Purchase();
            }
            _purchase.CarColorId = id.Value;
        }

        public void ChooseCarModel(int? id)
        {
            if (_purchase == null)
            {
                _purchase = new Purchase();
            }
            _purchase.CarModelId = id.Value;
        }

        public void ChooseConfig(int? id)
        {
            if (_purchase == null)
            {
                _purchase = new Purchase();
            }
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