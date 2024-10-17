using AutoMapper;
using MedicalTranscriptionSystem.Contracts.Users;
using MedicalTranscriptionSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalTranscriptionSystem.Contracts.Users
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Users, UsersDto>();
            CreateMap<UsersDto, Users>();
        }
    }
}
