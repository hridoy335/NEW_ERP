using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_CORE.Model.HRM
{
    public class HRD_EMPLOYEE_BANK_INFO
    {
        public long HEBI_ID { get; set; }
        public long HEBI_EMPLOYEE_ID { get; set; }
        public long HEBI_BANK_INFO { get; set; }
        public string HEBI_BRANCH_NAME { get; set; }
        public string HEBI_ACCOUNT_NO { get; set; }
        public string HEBI_STATUS { get; set; }
    }
}
