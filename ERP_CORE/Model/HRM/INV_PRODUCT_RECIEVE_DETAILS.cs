using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_CORE.Model.HRM
{
    public class INV_PRODUCT_RECIEVE_DETAILS
    {
        public long IPRD_ID { get; set; }
        public Nullable<long> IPRD_IPRE_ID { get; set; }
        public Nullable<long> IPRD_IPRO_ID { get; set; }
        public Nullable<decimal> IPRD_QUANTITY { get; set; }
        public Nullable<decimal> IPRD_UNIT_PRICE { get; set; }
        public Nullable<System.DateTime> IPRD_CREATE_DATE { get; set; }
        public string IPRE_STATUS { get; set; }
    }
}
