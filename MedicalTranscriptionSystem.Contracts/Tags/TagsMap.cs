using AutoMapper;
using MedicalTranscriptionSystem.Contracts.Users;
using MedicalTranscriptionSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalTranscriptionSystem.Contracts.Tags
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Tags, TagsDto>();
            CreateMap<TagsDto, Tags>();
        }
    }
}
