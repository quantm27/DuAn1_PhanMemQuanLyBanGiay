using _1_DAL.DomainMolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepository
{
    public interface ISizeRepository
    {
        public bool Add(Size obj);
        public bool Update(Size obj);
        public bool Delete(Size obj);
        public List<Size> GetAll();
    }
}
