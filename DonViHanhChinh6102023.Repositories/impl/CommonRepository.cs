using DonViHanhChinh6102023.Entities;
using DonViHanhChinh6102023.Entities.Entities;
using DonViHanhChinh6102023.Repositories.IInterfacee;
using Microsoft.EntityFrameworkCore;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DonViHanhChinh6102023.Repositories.impl
{
    public class CommonRepository<T> : ICommonRepository<T> where T : class
    {
        private readonly DBHanhChinhContext _context;

        public CommonRepository(DBHanhChinhContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public T GetByIdAsync(int id)
        {
            return _context.Set<T>().Find(id);
        }


        public List<T> GetAllObjects()
        {
            var data = _context.Set<T>().AsQueryable();

            // Tạo đối tượng PagedList
            var pagedData = data.ToList();

            return pagedData;
        }

        public T AddObjects(T entity)
        {
            // Thêm đối tượng vào cơ sở dữ liệu đồng bộ
            _context.Set<T>().Add(entity);
            _context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu

            // Trả về đối tượng sau khi thêm thành công (có thể bao gồm các giá trị đã được cập nhật bởi cơ sở dữ liệu)
            return entity;
        }

        public T UpdateObject(T entity)
        {

            _context.Set<T>().Update(entity);
            _context.SaveChanges();
            return entity;
        }

        public bool DeleteObjects(T entity)
        {

            if (entity != null)
            {
                _context.Set<T>().Remove(entity);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<T>> SearchByNameAsync(string name)
        {
            if (typeof(T).GetProperty("Name") == null)
            {
                throw new InvalidOperationException("Type T does not have a 'Name' property.");
            }

            return await _context.Set<T>().Where(e => e.GetType().GetProperty("Name").GetValue(e).ToString().Contains(name)).ToListAsync();
        }

    }

}
