using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Corp_Signup
    {
        public Int64 CorpID { get; set; }

        public string PersonName { get; set; }

        public string CompanyName { get; set; }

        public string WorkEmail { get; set; }

        public int Phone { get; set; }

        public bool CallBack { get; set; }

        public string Requirements { get; set; }

        public int FeedbackID { get; set; }

        public int CommandID { get; set; }

        public bool IsActive { get; set; }

        public int CreateBy { get; set; }

        public string CreateIP { get; set; }

        public DateTime CreateDate { get; set; }

        public int UpdateBy { get; set; }

        public string UpdateIP { get; set; }

        public string UpdateDate { get; set; }
    }
}
