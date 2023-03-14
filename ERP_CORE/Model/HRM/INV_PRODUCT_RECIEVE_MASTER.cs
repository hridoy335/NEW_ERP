using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_CORE.Model.HRM
{
    public class INV_PRODUCT_RECIEVE_MASTER
    {
        public long IPRE_ID { get; set; }
        public string IPRE_BILL_NUMBER { get; set; }
        public Nullable<System.DateTime> IPRE_BILL_DATE { get; set; }
        public string IPRE_CHALLAN_NUMBER { get; set; }
        public Nullable<System.DateTime> IPRE_CHALLAN_DATE { get; set; }
        public Nullable<decimal> IPRE_TOTAL_AMOUNT { get; set; }
        public string IPRE_STATUS { get; set; }
    }
}
