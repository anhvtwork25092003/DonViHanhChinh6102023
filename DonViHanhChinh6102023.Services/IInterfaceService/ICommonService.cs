using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonViHanhChinh6102023.Services.IInterfaceService
{
    public interface ICommonService<TEntity, TCreate, TUpdate, TDelete, TResponse>
    {
        List<TResponse> GetAllSync();
        TResponse GetOne(int id);
        TResponse Add(TCreate entityForCreate);
        TResponse Update(TUpdate entityForUpdate);
        bool Delete(TDelete entityForDelete);
    }
}
