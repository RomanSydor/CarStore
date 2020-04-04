using CarStore.Repositories;
using CarStore.Services;
using Ninject.Modules;

namespace IoSApp.Util
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IBrandRepository>().To<BrandRepository>();
            Bind<ICarModelRepository>().To<CarModelRepository>();
            Bind<ICarColorRepository>().To<CarColorRepository>();
            Bind<IConfigRepository>().To<ConfigRepository>();
            Bind<IPurchaseRepository>().To<PurchaseRepository>();
            Bind<ICarTypeRepository>().To<CarTypeRepository>();
            Bind<IPurchaseService>().To<PurchaseService>();
            Bind<ICarSortService>().To<CarSortService>();
            Bind<IIdSaverService>().To<IdSaverService>().InSingletonScope();
        }
    }
}