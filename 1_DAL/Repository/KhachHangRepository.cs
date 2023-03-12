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
    public class KhachHangRepository : IKhachHangRepository
    {
        private QuanLyBanHangGiayContext _dbContext;
        private List<KhachHang> _lstKhachHang;
        public KhachHangRepository()
        {
            _dbContext = new QuanLyBanHangGiayContext();
            _lstKhachHang = new List<KhachHang>();
        }

        public bool Add(KhachHang obj)
        {
            _dbContext.KhachHangs.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(KhachHang obj)
        {
            _dbContext.KhachHangs.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<KhachHang> GetAll()
        {
            _lstKhachHang = _dbContext.KhachHangs.ToList();
            return _lstKhachHang;
        }

        public bool Update(KhachHang obj)
        {
            _dbContext.KhachHangs.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
