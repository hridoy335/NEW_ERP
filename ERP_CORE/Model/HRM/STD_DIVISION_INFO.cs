using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_CORE.Model.HRM
{
    public class STD_DIVISION_INFO
    {
        public long SDIV_ID { get; set; }
        public string SDIV_DIVISION_NAME { get; set; }
        public string SDIV_DIVISION_NAME_NATIVE { get; set; }
        public Nullable<long> SDIV_COUNTRY_ID { get; set; }
        public string SDIV_STATUS { get; set; }
    }
}
