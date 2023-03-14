using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_CORE.Model.HRM
{
    public class HRD_EMPLOYEE_EDU_INFO
    {
        public long HEEI_ID { get; set; }
        public long HEEI_EMPLOYEE_ID { get; set; }
        public long HEEI_EDUCATION_TYPE { get; set; }
        public string HEEI_INSTITUTE_NAME { get; set; }
        public string HEEI_PASSING_YEAR { get; set; }
        public string HEEI_RESULT { get; set; }
        public string HEEI_STATUS { get; set; }
    }
}
