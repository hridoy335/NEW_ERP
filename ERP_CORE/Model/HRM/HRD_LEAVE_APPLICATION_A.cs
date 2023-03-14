using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_CORE.Model.HRM
{
    public class HRD_LEAVE_APPLICATION_A
    {
        public long HLAP_AUDIT_ID { get; set; }
        public long HLAP_EMPLOYEE_ID { get; set; }
        public string HLAP_APPLICATION_NO { get; set; }
        public string HLAP_APPLICATION_PURPOSE { get; set; }
        public Nullable<System.DateTime> HLAP_APPLICATION_DATE { get; set; }
        public Nullable<System.DateTime> HLAP_START_DATE { get; set; }
        public Nullable<System.DateTime> HLAP_END_DATE { get; set; }
        public Nullable<decimal> HLAP_LEAVE_DURATION { get; set; }
        public Nullable<long> HLAP_TYPE { get; set; }
        public Nullable<long> HLAP_APPROVAL_USER_LEVEL { get; set; }
        public Nullable<long> HLAP_APPROVAL_USER { get; set; }
        public Nullable<long> HLAP_CMD_BY { get; set; }
        public string HLAP_STATUS { get; set; }
        public string HLAP_CMD_FLAG { get; set; }
    }
}
