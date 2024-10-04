﻿

namespace DemoDB2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class LichLamViec
    {
       public int LichLamViecID { get; set; }
        public int NhanVienID { get; set; }
        public int Ngay { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        [Range(1, 2, ErrorMessage = "Chỉ được đăng ký tối đa 2 ca mỗi ngày")]
        public int SoCaLamViec { get; set; }
        public bool CaSang { get; set; }
        public bool CaChieu { get; set; }
        public bool CaToi { get; set; }
        public bool CaDem { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}