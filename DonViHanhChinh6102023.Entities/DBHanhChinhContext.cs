using DonViHanhChinh6102023.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace DonViHanhChinh6102023.Entities
{
        public class DBHanhChinhContext : DbContext
        {

            public DBHanhChinhContext(DbContextOptions<DBHanhChinhContext> options) : base(options)
            {

            }

            public DbSet<Province> provinces { get; set; }
            public DbSet<District> Districts { get; set; }
            public DbSet<Ward> Wards { get; set; }

     
        }
}