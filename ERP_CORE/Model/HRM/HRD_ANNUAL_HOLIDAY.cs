using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_CORE.Model.HRM
{
    public class HRD_ANNUAL_HOLIDAY
    {
        public long HANH_ID { get; set; }
        public System.DateTime HANH_DATE { get; set; }
        public string HANH_NAME { get; set; }
        public string HANH_DESCRIPTION { get; set; }
        public string HANH_STATUS { get; set; }
    }
}
