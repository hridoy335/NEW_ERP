using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_CORE.Model.HRM
{
    public class HRD_SALARY_GRADE
    {
        public long HSGR_ID { get; set; }
        public string HSGR_SHORT_CODE { get; set; }
        public string HSGR_NAME { get; set; }
        public Nullable<decimal> HSGR_GROSS_SALARY_PER { get; set; }
        public Nullable<decimal> HSGR_TRANSPORT_PER { get; set; }
        public Nullable<decimal> HSGR_ACCOMMODATION_PER { get; set; }
        public Nullable<decimal> HSGR_MEDICAL_PER { get; set; }
        public Nullable<decimal> HSGR_MOBILE_PER { get; set; }
        public string HSGR_STATUS { get; set; }
    }
}
