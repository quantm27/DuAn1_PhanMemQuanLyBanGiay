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
    public class HoaDonReposiory : IHoaDonRepository
    {
        private QuanLyBanHangGiayContext _dbContext;
        private List<HoaDon> _lstHoaDon;
        public HoaDonReposiory()
        {
            _dbContext = new QuanLyBanHangGiayContext();
            _lstHoaDon = new List<HoaDon>();
        }

        public bool Add(HoaDon obj)
        {
            _dbContext.HoaDons.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(HoaDon obj)
        {
            _dbContext.HoaDons.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<HoaDon> GetAll()
        {
            _lstHoaDon = _dbContext.HoaDons.ToList();
            return _lstHoaDon;
        }

        public bool Update(HoaDon obj)
        {
            _dbContext.HoaDons.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
