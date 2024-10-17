using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalTranscriptionSystem.Data.Models
{
    public class User : BaseModel
    {
        public string? EmailAddress {  get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
