//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoDB2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LichLamViec
    {
        public int LichLamViecID { get; set; }
        public int NhanVienID { get; set; }
        public int Ngay { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public int SoCaLamViec { get; set; }
        public bool CaSang { get; set; }
        public bool CaChieu { get; set; }
        public bool CaToi { get; set; }
        public bool CaDem { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
    }
}
