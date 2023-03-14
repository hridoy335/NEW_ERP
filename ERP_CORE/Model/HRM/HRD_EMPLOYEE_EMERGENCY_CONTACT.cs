using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_CORE.Model.HRM
{
    public class HRD_EMPLOYEE_EMERGENCY_CONTACT
    {
        public long HEEC_ID { get; set; }
        public long HEEC_EMPLOYEE_ID { get; set; }
        public int HEEC_CONTACT_SERIAL { get; set; }
        public string HEEC_CONTACT_NAME { get; set; }
        public string HEEC_CONTACT_NO { get; set; }
        public string HEEC_CONTACT_RELATION { get; set; }
        public string HEEC_STATUS { get; set; }
    }
}
