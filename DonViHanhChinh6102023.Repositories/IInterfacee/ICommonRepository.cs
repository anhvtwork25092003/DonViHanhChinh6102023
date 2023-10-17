
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonViHanhChinh6102023.Repositories.IInterfacee

{
    public interface ICommonRepository<T>
    {
        T GetByIdAsync(int id);
        List<T> GetAllObjects();

        T AddObjects(T entity);
        T UpdateObject( T entity);
        bool DeleteObjects(T entity);
        Task<IEnumerable<T>> SearchByNameAsync(string name);
    }

}

