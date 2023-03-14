using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_CORE.Model.HRM
{
    public class HRD_HOLIDAY_POLICY_DETAIL
    {
        public long HHPD_ID { get; set; }
        public Nullable<long> HHPD_POLICY_ID { get; set; }
        public string HHPD_DAY_NAME { get; set; }
    }
}
