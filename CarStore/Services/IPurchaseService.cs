using CarStore.Models;

namespace CarStore.Services
{
    public interface IPurchaseService
    {
        void BrandChoose(int? id);
        void CarTypeChoose(int? id);
        void CarModelChoose(int? id);
        void ConfigChoose(int? id);
        void CarColorChoose(int? id);
        Purchase Create();
    }
}