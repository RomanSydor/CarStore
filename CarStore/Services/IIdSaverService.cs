using CarStore.Models;

namespace CarStore.Services
{
    public interface IIdSaverService
    {
        void BrandIdSave(int? id);
        void CarTypeIdSave(int? id);
        void CarModelIdSave(int? id);
        void ConfigIdSave(int? id);
        void CarColorIdSave(int? id);
        SavedId AllIds();
    }
}
