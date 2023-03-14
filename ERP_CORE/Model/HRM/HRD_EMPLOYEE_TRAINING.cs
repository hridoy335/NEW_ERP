using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_CORE.Model.HRM
{
    public class HRD_EMPLOYEE_TRAINING
    {
        public long HETR_ID { get; set; }
        public long HETR_EMPLOYEE_ID { get; set; }
        public string HETR_TRAINING_TITLE { get; set; }
        public string HETR_INSTITUTE { get; set; }
        public Nullable<System.DateTime> HETR_START_DATE { get; set; }
        public Nullable<System.DateTime> HETR_END_DATE { get; set; }
        public Nullable<decimal> HETR_TAINING_PERIOD { get; set; }
        public string HETR_STATUS { get; set; }
    }
}
