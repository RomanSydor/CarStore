using CarStore.Models;

namespace CarStore.Services
{
    public interface IPurchaseService
    {
        void ChooseBrand(int? id);
        void ChooseCarModel(int? id);
        void ChooseConfig(int? id);
        void ChooseCarColor(int? id);
        Purchase Create();
    }
}