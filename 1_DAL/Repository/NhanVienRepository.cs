using _1_DAL.Dbcontext;
using _1_DAL.DomainMolder;
using _1_DAL.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Repository
{
    public class NhanVienRepository : INhanVienRepository
    {
        private QuanLyBanHangGiayContext _dbContext;
        public List<NhanVien> _lstNhanVien;
        public NhanVienRepository()
        {
            _dbContext = new QuanLyBanHangGiayContext();
            _lstNhanVien = new List<NhanVien>();
        }
        public bool Add(NhanVien obj)
        {
            _dbContext.NhanViens.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(NhanVien obj)
        {
            _dbContext.NhanViens.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<NhanVien> GetAll()
        {
            _lstNhanVien = _dbContext.NhanViens.ToList();
            return _lstNhanVien;
        }

        public NhanVien GetNhanVien(string username, string matkhau)
        {
            NhanVien nv = _dbContext.NhanViens.FirstOrDefault(p => p.Username == username && p.MatKhau == matkhau);
            return nv;
        }

        public bool Update(NhanVien obj)
        {
            _dbContext.NhanViens.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
