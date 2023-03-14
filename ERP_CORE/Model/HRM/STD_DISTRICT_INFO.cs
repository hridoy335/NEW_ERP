using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_CORE.Model.HRM
{
    public class STD_DISTRICT_INFO
    {
        public long SDIS_ID { get; set; }
        public string SDIS_NAME { get; set; }
        public string SDIS_NAME_NATIVE { get; set; }
        public string SDIS_STATUS { get; set; }
        public Nullable<long> SDIS_DIVISION_ID { get; set; }
    }
}
