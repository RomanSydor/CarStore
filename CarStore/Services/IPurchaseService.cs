using CarStore.Models;

namespace CarStore.Services
{
    public interface IPurchaseService
    {
        void BrandChoose();
        void CarTypeChoose();
        void CarModelChoose();
        void ConfigChoose();
        void CarColorChoose();
        Purchase Create();
    }
}