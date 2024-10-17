using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalTranscriptionSystem.Contracts.Treatments
{
    public interface ITreatmentsService : IService
    {
        List<TreatmentsDto>? GetTreatments();  
    }
}
