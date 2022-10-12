using AutoMapper;
using Data= Student_api.Data;
using Student_api.DomainModels;

namespace Student_api.Profiles
{
    public class AutoMapProfile:Profile
    {
        public AutoMapProfile()
        {
           CreateMap<Data.Students,Students>().ReverseMap();
            CreateMap<Data.Gender, Gender>().ReverseMap();
            CreateMap<Data.Address, Address>().ReverseMap();
        }


    }
}
