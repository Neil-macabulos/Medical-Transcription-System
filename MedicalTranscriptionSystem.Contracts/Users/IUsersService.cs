﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalTranscriptionSystem.Contracts.Users
{
    public interface IUsersService : IService
    {
        List<UsersDto>? GetUsers();  
    }
}