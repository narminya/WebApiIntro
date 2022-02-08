using AutoMapper;
using Domain.Entity;
using Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Mapper
{
   public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Student, StudentDto>().ReverseMap();
        }
    }
}
