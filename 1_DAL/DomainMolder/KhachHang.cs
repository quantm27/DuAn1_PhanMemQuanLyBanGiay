﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.DomainMolder
{
    public class KhachHang
    {
        public Guid ID { get; set; }
     
        public string Ho { get; set; }
        public string TenDem { get; set; }
       
        public string Ten { get; set; }
        public int? Poin { get; set; }

        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
      
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string ThanhPho { get; set; }
        public string QuocGia { get; set; }
        public int? TrangThai { get; set; }
        public List<HoaDon> hoadon { get; set; }
    }
}
