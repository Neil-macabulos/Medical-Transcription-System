using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalTranscriptionSystem.Contracts.Tags
{
    public interface ITagsService : IService
    {
        List<TagsDto>? GetTags();  
    }
}
