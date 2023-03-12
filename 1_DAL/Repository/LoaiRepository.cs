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
    public class LoaiRepository : ILoaiSanPhamRepository
    {
        private QuanLyBanHangGiayContext _dbContext;
        private List<LoaiSanPham> _lstLoai;
        public LoaiRepository()
        {
            _dbContext = new QuanLyBanHangGiayContext();
            _lstLoai = new List<LoaiSanPham>();
        }

        public bool Add(LoaiSanPham obj)
        {
            _dbContext.LoaiSanPhams.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(LoaiSanPham obj)
        {
            _dbContext.LoaiSanPhams.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<LoaiSanPham> GetAll()
        {
            _lstLoai = _dbContext.LoaiSanPhams.ToList();
            return _lstLoai;
        }

        public bool Update(LoaiSanPham obj)
        {
            _dbContext.LoaiSanPhams.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
