using _1_DAL.DomainMolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepository
{
    public interface INhanVienRepository
    {
        public bool Add(NhanVien obj);
        public bool Update(NhanVien obj);
        public bool Delete(NhanVien obj);
        public NhanVien GetNhanVien(string username , string matkhau);
        public List<NhanVien> GetAll();
    }
}
