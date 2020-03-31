using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.Services
{
    public interface IPurchaseService
    {
        void ChooseBrand(int? id);
        void ChooseCarModel(int? id);
        void ChooseConfig(int? id);
        void ChooseCarColor(int? id);

    }
}