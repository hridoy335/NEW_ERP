using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_CORE.Model.HRM
{
    public class HRD_REQUISITION_REQUESTS
    {
        public long HREQ_ID { get; set; }
        public Nullable<long> HREQ_HEMP_ID { get; set; }
        public Nullable<long> HREQ_IPRO_ID { get; set; }
        public Nullable<decimal> HREQ_QUANTITY { get; set; }
        public Nullable<System.DateTime> HREQ_REQISITON_DATE { get; set; }
        public string HREQ_TYPE { get; set; }
        public string HREQ_SERIAL_NUMBER { get; set; }
        public string HREQ_STATUS { get; set; }
    }
}
