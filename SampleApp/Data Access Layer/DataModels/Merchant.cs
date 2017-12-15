using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApp.Data_Access_Layer.DataModels
{
    public class Merchant : AuditProperties
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(100)]
        public string BusinessName { get; set; }

        [Required]
        [MaxLength(255)]
        [DataType(DataType.EmailAddress)]
        public String EmailID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Password { get; set; }

        [Required]
        public DateTime Insertedon { get; set; }
        public DateTime Modifiedon { get; set; }
        [Required]
        public int CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
