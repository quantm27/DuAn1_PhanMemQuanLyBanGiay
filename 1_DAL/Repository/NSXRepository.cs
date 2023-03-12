using _1_DAL.Dbcontext;
using _1_DAL.DomainMolder;
using _1_DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Repository
{
    internal class NSXRepository : INSXRepository
    {
        private QuanLyBanHangGiayContext _dbContext;
        public List<NSX> _lstNSX;
        public NSXRepository()
        {
            _dbContext = new QuanLyBanHangGiayContext();
            _lstNSX = new List<NSX>();
        }
        public bool Add(NSX obj)
        {
            _dbContext.NSXs.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(NSX obj)
        {
            _dbContext.NSXs.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<NSX> GetAll()
        {
            _lstNSX = _dbContext.NSXs.ToList();
            return _lstNSX;
        }


        public bool Update(NSX obj)
        {
            _dbContext.NSXs.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }

       
    }
}
