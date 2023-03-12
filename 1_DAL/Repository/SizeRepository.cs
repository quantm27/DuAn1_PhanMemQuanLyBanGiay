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
    internal class SizeRepository : ISizeRepository
    {
        private QuanLyBanHangGiayContext _dbContext;
        private List<Size> _lstSize;
        public SizeRepository()
        {
            _dbContext = new QuanLyBanHangGiayContext();
            _lstSize = new List<Size>();
        }

        public bool Add(Size obj)
        {
            _dbContext.Sizes.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(Size obj)
        {
            _dbContext.Sizes.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<Size> GetAll()
        {
            _lstSize = _dbContext.Sizes.ToList();
            return _lstSize;
        }

        public bool Update(Size obj)
        {
            _dbContext.Sizes.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
