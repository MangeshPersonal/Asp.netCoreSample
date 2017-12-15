using SampleApp.Data_Access_Layer.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApp.Data_Access_Layer.DatModels
{
    public class Customer: AuditProperties
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Firstname { get; set; }

        [Required]
        [MaxLength(50)]
        public string Lastname { get; set; }
        [MaxLength(100)]
        [Required]
        public string BillingAddress { get; set; }

        [MaxLength(100)]
        public string ShippingAddress { get; set; }

        [MaxLength(50)]
        public string CustomField1 { get; set; }
        [MaxLength(50)]
        public string CustomField2 { get; set; }

        [MaxLength(50)]
        public string CustomField3 { get; set; }

        [MaxLength(50)]
        public string CustomField4 { get; set; }

        [MaxLength(40)]
        [Required]
        public string LoginID { get; set; }

        [MaxLength(40)]
        [Required]
        public string Password { get; set; }
        [Required]
        [MaxLength(255)]
        public string Email { get; set; }
        [MaxLength(15)]
       public string PhoneNumber { get; set; }
        [Required]
         public DateTime Insertedon { get; set; }
         public DateTime Modifiedon { get; set; }
        [Required]
        public int CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
