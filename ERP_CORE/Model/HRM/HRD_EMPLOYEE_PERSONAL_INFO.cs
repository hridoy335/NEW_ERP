using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_CORE.Model.HRM
{
    public class HRD_EMPLOYEE_PERSONAL_INFO
    {
        public long HEPI_ID { get; set; }
        public long HEPI_EMPLOYEE_ID { get; set; }
        public Nullable<System.DateTime> HEPI_DATE_OF_BIRTH { get; set; }
        public string HEPI_NID { get; set; }
        public string HEPI_PASSPORT { get; set; }
        public string HEPI_PERSONAL_EMAIL { get; set; }
        public string HEPI_CONTACT_NO { get; set; }
        public string HEPI_FATHER_NAME { get; set; }
        public string HEPI_MOTHER_NAME { get; set; }
        public Nullable<long> HEPI_DISTRICT { get; set; }
        public string HEPI_PRESENT_ADDRESS { get; set; }
        public string HEPI_PERMANENT_ADDRESS { get; set; }
        public Nullable<long> HEPI_GENDER { get; set; }
        public Nullable<long> HEPI_MARITAL_STATUS { get; set; }
        public Nullable<long> HEPI_RELIGION { get; set; }
        public Nullable<long> HEPI_BLOOD_GROUP { get; set; }

    }
}
