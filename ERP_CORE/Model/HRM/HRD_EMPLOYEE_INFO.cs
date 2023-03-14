using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_CORE.Model.HRM
{
    public class HRD_EMPLOYEE_INFO
    {
        public long HEMP_ID { get; set; }
        public string HEMP_IDENTITY_PIN { get; set; }
        public string HEMP_NAME { get; set; }
        public string HEMP_PICTURE_URL { get; set; }
        public string HEMP_PICTURE_EXT { get; set; }
        public string HEMP_PICTURE_NAME { get; set; }
        public string HEMP_CV_URL { get; set; }
        public string HEMP_CV_EXT { get; set; }
        public string HEMP_CV_NAME { get; set; }
        public string HEMP_EMAIL { get; set; }
        public System.DateTime HEMP_JOINING_DATE { get; set; }
        public Nullable<System.DateTime> HEMP_CONFIRMATION_DATE { get; set; }
        public Nullable<long> HEMP_DEPARTMENT { get; set; }
        public Nullable<long> HEMP_DESIGNATION { get; set; }
        public Nullable<long> HEMP_SALARY_GRADE { get; set; }
        public Nullable<long> HEMP_SHIFT_CONFIGURATION { get; set; }
        public Nullable<long> HEMP_HOLIDAY_POLICY { get; set; }
        public Nullable<long> HEMP_EMPLOYEE_TYPE { get; set; }
        public Nullable<long> HEMP_EMPLOYEE_STATUS { get; set; }

        public virtual HRD_DEPARTMENT HRD_DEPARTMENT { get; set; }
        public virtual HRD_DESIGNATION HRD_DESIGNATION { get; set; }
    }
}
