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
    public class HoaDonChiTietRepository : IHoaDonChiTietRepository
    {
        private QuanLyBanHangGiayContext _dbContext;
        private List<HoaDonChiTiet> _lstHoaDonChiTiet;
        public HoaDonChiTietRepository()
        {
            _dbContext = new QuanLyBanHangGiayContext();
            _lstHoaDonChiTiet = new List<HoaDonChiTiet>();
        }

        public bool Add(HoaDonChiTiet obj)
        {
            _dbContext.HoaDonChiTiet.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(HoaDonChiTiet obj)
        {
            _dbContext.HoaDonChiTiet.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<HoaDonChiTiet> GetAll()
        {
            _lstHoaDonChiTiet = _dbContext.HoaDonChiTiet.ToList();
            return _lstHoaDonChiTiet;
        }

        public bool Update(HoaDonChiTiet obj)
        {
            _dbContext.HoaDonChiTiet.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
