﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.DomainMolder
{
    public class NhanVien
    {
        public Guid ID { get; set; }
        public Guid IDCV { get; set; }
        
        public string Username { get; set; }
        public string HoTen{ get; set; }
      
        public int GioiTinh { get; set; }
        public string Email { get; set; }
        public string AnhNv { get;set; }
        public DateTime NamSinh { get; set; }
        public int SoDienThoai { get; set; }
        public int CCCD { get; set; }
        public string MatKhau { get; set; }
        public string DiaChi { get; set; }
        public int TrangThai { get; set; }
        public string GhiChu { get; set; }
        public ChucVu ChucVu { get; set; }
        public List<HoaDon> hoadon { get; set; }
    }
}
