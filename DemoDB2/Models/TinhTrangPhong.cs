
namespace DemoDB2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TinhTrangPhong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TinhTrangPhong()
        {
            this.Phong = new HashSet<Phong>();
        }
    
        public int IDTinhTrang { get; set; }
        public string TenTinhTrang { get; set; }
        public List<TinhTrangPhong> ListTinhTrang { get; internal set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phong> Phong { get; set; }
    }
}
