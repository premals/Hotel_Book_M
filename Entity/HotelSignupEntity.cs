using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class HotelSignupEntity
    {
        public Int64 HotelID { get; set; }

        public string Password { get; set; }

        public string RePassword { get; set; }

        public string HotelLicenceNumber { get; set; }

        public Boolean GovtApproved { get; set; }

        public string HotelName { get; set; }

        public string Landmark { get; set; }

        public string HotelAddress1 { get; set; }

        public string HotelAddress2 { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public int Pincode { get; set; }

        public string State { get; set; }

        public int ReceptionPhone { get; set; }

        public int Plan1 { get; set; }
        
        public string Plan1Description { get; set; }

        public int Plan1Rooms { get; set; }

        public bool Plan2 { get; set; }

        public string Plan2Description { get; set; }

        public int Plan2Rooms { get; set; }

        public bool Plan3 { get; set; }

        public string Plan3Description { get; set; }

        public int Plan3Rooms { get; set; }

        public int PayPerDay { get; set; }

        public int TotalRooms { get; set; }

        public bool DaysPolicy { get; set; }

        public int RoomsForDays { get; set; }

        public string CheckInTime { get; set; }
        
        public string Chains { get; set; }

        public string Ameneties { get; set; }

        public string Specialities { get; set; }

        public string RequirementFromUs { get; set; }

        public bool ForUnMarriedLocal { get; set; }

        public string PersonName { get; set; }

        public string PersonDesignation { get; set; }

        public string PersonEmail { get; set; }

        public int PersonContact { get; set; }

        public int Star { get; set; }

        public string Website { get; set; }

        public bool IsActive { get; set; }

        public string CreateBy { get; set; }

        public string CreateIP { get; set; }

        public DateTime CreateDate { get; set; }

        public string UpdateBy { get; set; }

        public string UpdateIP { get; set; }

        public DateTime UpdateDate { get; set; }

        public int CommandID { get; set; }
    }
}
