using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_CORE.Model.HRM
{
    public class HRD_SHIFT_CONFIGURATION
    {
        public long HSHC_ID { get; set; }
        public string HSHC_SHORT_CODE { get; set; }
        public string HSHC_NAME { get; set; }
        public System.DateTime HSHC_START_TIME { get; set; }
        public System.DateTime HSHC_END_TIME { get; set; }
        public Nullable<decimal> HSHC_DURATION { get; set; }
        public System.DateTime HSHC_MAX_LATE_LIMIT { get; set; }
        public System.DateTime HSHC_EARLY_OUT_LIMIT { get; set; }
        public Nullable<decimal> HSHC_OVERTIME_LIMIT { get; set; }
        public string HSHC_DESCRIPTION { get; set; }
        public string HSHC_STATUS { get; set; }
    }
}
