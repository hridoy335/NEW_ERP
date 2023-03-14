using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_CORE.Model.HRM
{
    public class HRD_EMPLOYEE_SPOUSE
    {
        public long HESP_ID { get; set; }
        public long HESP_EMPLOYEE_ID { get; set; }
        public string HESP_SPOUSE_NAME { get; set; }
        public Nullable<long> HESP_GENDER { get; set; }
        public string HESP_STATUS { get; set; }
    }
}
