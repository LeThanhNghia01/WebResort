

namespace DemoDB2.Models
{
    using System;
    using System.Collections.Generic;
    using System.Web;

    public partial class MonAn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MonAn()
        {
            this.DichVuSuDung = new HashSet<DichVuSuDung>();
        }
    
        public int MonAnID { get; set; }
        public string TenMon { get; set; }
        public Nullable<decimal> GiaMon { get; set; }
        public Nullable<int> IDBan { get; set; }
        public string ImageMonAn { get; set; }
        public HttpPostedFileBase UploadImage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DichVuSuDung> DichVuSuDung { get; set; }
    }
}
