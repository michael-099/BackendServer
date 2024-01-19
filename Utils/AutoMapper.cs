using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using UserAuthentication.DTOs.ScheduleDTOs;
using UserAuthentication.Models;
using UserAuthentication.Models.DTOs.UserDTOs;

namespace UserAuthentication.Utils
{
    public class AutoMapper:Profile
    {
        public AutoMapper()
        {
            CreateMap<Doctor, UpdateDoctorDTO>().ReverseMap();
            CreateMap<Doctor, UsageDoctorDTO>().ReverseMap();
            CreateMap<Schedule, ScheduleDTO>().ReverseMap();
        }
    }
}