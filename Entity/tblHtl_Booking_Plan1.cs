//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblHtl_Booking_Plan1
    {
        public int Index_ID { get; set; }
        public string BookingID { get; set; }
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public long PhoneNo { get; set; }
        public System.DateTime CustomerBDate { get; set; }
        public int People { get; set; }
        public byte BookedRooms { get; set; }
        public bool Plan1 { get; set; }
        public System.DateTime CheckInDate { get; set; }
        public Nullable<System.DateTime> CheckOutDate { get; set; }
        public string CheckInTime { get; set; }
        public int Length { get; set; }
        public Nullable<int> HotelID { get; set; }
        public Nullable<byte> TotalRooms { get; set; }
        public string DiscountCode { get; set; }
        public string VerificationCode { get; set; }
        public Nullable<bool> OnSitePay { get; set; }
        public Nullable<bool> BankPay { get; set; }
        public int Payment { get; set; }
        public bool BookCheck { get; set; }
        public bool SuccessBook { get; set; }
        public byte CommandID { get; set; }
        public bool IsActive { get; set; }
        public int CreateBy { get; set; }
        public string CreateIP { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int UpdateBy { get; set; }
        public string UpdateIP { get; set; }
        public System.DateTime UpdateDate { get; set; }
    }
}
