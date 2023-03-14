using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_CORE.Model.HRM
{
    public class HRD_EMPLOYEE_EXPERIENCE
    {
        public long HEEX_ID { get; set; }
        public long HEEX_EMPLOYEE_ID { get; set; }
        public string HEEX_ORGANIZATION_NAME { get; set; }
        public Nullable<System.DateTime> HEEX_JOIN_DATE { get; set; }
        public Nullable<System.DateTime> HEEX_LEAVE_DATE { get; set; }
        public Nullable<decimal> HEEX_EXP_DURATION { get; set; }
        public string HEEX_STATUS { get; set; }
    }
}
