using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using AutoMapper;
using SampleDAL.ViewModels;
using SampleDAL.DbModels;

namespace SampleCore.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<VMCategory, Category>(); // Define mapping from CategoryViewModel to Category
            CreateMap<Category, VMCategory>(); // Define mapping from Category to CategoryViewModel
        }
    }
}
