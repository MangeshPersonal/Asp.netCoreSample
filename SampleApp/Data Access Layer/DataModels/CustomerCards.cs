using SampleApp.Data_Access_Layer.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApp.Data_Access_Layer.DatModels
{
    public class CustomerCards: AuditProperties
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerCardID { get; set; }

        [ForeignKey("ID")]
        public Customer CustomerID { get; set; }

        [Required]
        [MaxLength(4)]
        public string ExpMonth { get; set; }

        [Required]
        [MaxLength(4)]
        public string Expyear { get; set; }
        [Required]
        [MaxLength(30)]
        public string CardToken { get; set; }
        [Required]
        public DateTime Insertedon { get; set; }
        public DateTime Modifiedon { get; set; }
        [Required]
        public int CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
