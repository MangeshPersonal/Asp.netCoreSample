using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleApp.Data_Access_Layer.DataModels
{
    public class Profile:AuditProperties
    {
        public Profile()
        {
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName  { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }


        [Required]
        public DateTime Insertedon { get; set; }
        public DateTime Modifiedon { get; set; }
        [Required]
        public int CreatedBy { get; set; } // Can be adminId or ProfileId for that particular
        public string ModifiedBy { get; set; }
    }
}
