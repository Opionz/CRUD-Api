using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_Api.Models
{
    public class StaffMicroservices
    {
        public long ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string OtherName { get; set; }

        public long StaffID { get; set; }

        public string Email { get; set; }

        public long PhoneNumber { get; set; }

        public string Address { get; set; }

        public string AccountNumber { get; set; }

        public long BankID { get; set; }

        public string BVNNo { get; set; }

        public string AccountName { get; set; }

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public DateTime DateofEmploymentTermination { get; set; }

        public long PayGroup { get; set; }

        public int Status { get; set; }

        
    }
}