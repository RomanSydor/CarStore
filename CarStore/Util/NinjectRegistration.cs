using CarStore.Repositories;
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
        }
    }
}