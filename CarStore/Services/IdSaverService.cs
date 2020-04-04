using CarStore.Models;

namespace CarStore.Services
{
    public class IdSaverService : IIdSaverService
    {
        SavedId _savedId;

        public void BrandIdSave(int? id)
        {
            if (_savedId == null)
            {
                _savedId = new SavedId();
            }
            _savedId.SavedBrandId = id.Value;
        }

        public void CarColorIdSave(int? id)
        {
            if (_savedId == null)
            {
                _savedId = new SavedId();
            }
            _savedId.SavedCarColorId = id.Value;
        }

        public void CarModelIdSave(int? id)
        {
            if (_savedId == null)
            {
                _savedId = new SavedId();
            }
            _savedId.SavedCarModelId = id.Value;
        }

        public void CarTypeIdSave(int? id)
        {
            if (_savedId == null)
            {
                _savedId = new SavedId();
            }
            _savedId.SavedCarTypeId = id.Value;
        }

        public void ConfigIdSave(int? id)
        {
            if (_savedId == null)
            {
                _savedId = new SavedId();
            }
            _savedId.SavedConfigId = id.Value;
        }
        public SavedId AllIds()
        {
            if (_savedId == null)
            {
                _savedId = new SavedId();
            }
            return _savedId;
        }
    }
}