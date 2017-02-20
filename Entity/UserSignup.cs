using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class UserSignup
    {
        #region
        //* User Registration Entity

        public Int64 User_ID
        {
            get
            {
                return User_ID;
            }
            set
            {
                User_ID = value;
            }
        }

        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        public string Email
        {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
            }
        }

        public string Password
        {
            get
            {
                return Password;
            }
            set
            {
                Password = value;
            }
        }

        public string RePassword
        {
            get
            {
                return RePassword;
            }
            set
            {
                RePassword = value;
            }
        }

        public string PhoneNo
        {
            get
            {
                return PhoneNo;
            }
            set
            {
                PhoneNo = value;
            }
        }

        public int CommandID
        {
            get
            {
                return CommandID;
            }
            set
            {
                CommandID = value;
            }
        }

        public bool IsActive
        {
            get
            {
                return IsActive;
            }
            set
            {
                IsActive = value;
            }
        }

        public int CreateBy
        {
            get
            {
                return CreateBy;
            }
            set
            {
                CreateBy = value;
            }
        }

        public string CreateIP
        {
            get
            {
                return CreateIP;
            }

            set
            {
                CreateIP = value;
            }
        }

        public DateTime CreateDate
        {
            get
            {
                return CreateDate;
            }
            set
            {
                CreateDate = value;
            }
        }

        public int UpdateBy
        {
            get
            {
                return UpdateBy;
            }
            set
            {
                UpdateBy = value;
            }
        }

        public string UpdateIP
        {
            get
            {
                return UpdateIP;
            }
            set
            {
                UpdateIP = value;
            }
        }

        public DateTime UpdateDate
        {
            get
            {
                return UpdateDate;
            }
            set
            {
                UpdateDate = value;
            }
        }
        #endregion


    }
}
