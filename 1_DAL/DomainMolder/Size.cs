﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.DomainMolder
{
    public class Size
    {
        public Guid ID { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public int TrangThai { get; set; }
        public string GhiChu { get; set; }
        public List<SanPhamChiTiet> spct
        {
            get; set;
        }
    }
}
