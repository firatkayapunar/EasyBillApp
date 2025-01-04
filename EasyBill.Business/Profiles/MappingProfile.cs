using AutoMapper;
using EasyBill.Business.Dtos.BillType;
using EasyBill.Entities;

namespace EasyBill.Business.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // BillType - DTO Mappings
            CreateMap<BillType, BillTypeDto>().ReverseMap();
            CreateMap<BillType, BillTypeCreateDto>().ReverseMap();
            CreateMap<BillType, BillTypeUpdateDto>().ReverseMap();
        }
    }
}
