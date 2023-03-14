using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_CORE.Model.HRM
{
    public class HRD_EMPLOYEE_CHILDREN_INFO
    {
        public long HECI_ID { get; set; }
        public long HECI_EMPLOYEE_ID { get; set; }
        public string HECI_CHILD_NAME { get; set; }
        public Nullable<long> HECI_GENDER { get; set; }
        public string HECI_STATUS { get; set; }
    }
}
