using System;
using System.Collections.Generic;

namespace LibraryManagementSystem.Models
{
    public class Member
    {
        public Guid MemberId { get; private set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string MembershipStatus { get; private set; } //Active, Inactive, Suspended
        public int BorrowingQuota { get; private set; }     

        public Member(string fullName, string email, string phoneNumber)
        {
            MemberId = Guid.NewGuid();
            FullName = fullName;
            Email = email;
            PhoneNumber = phoneNumber;
            MembershipStatus = "Active";
            BorrowingQuota = 5;
        }

        //UpdateBorrowingQuota()
    }
}
