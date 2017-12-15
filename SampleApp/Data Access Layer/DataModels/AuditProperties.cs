using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApp.Data_Access_Layer.DataModels
{
    interface AuditProperties
    {
        DateTime Insertedon { get; set; }
        DateTime Modifiedon { get; set; }
        int CreatedBy { get; set; } // Can be adminId or ProfileId for that particular
        string ModifiedBy { get; set; }
    }
}
