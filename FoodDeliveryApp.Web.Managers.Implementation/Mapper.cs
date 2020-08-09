using AutoMapper;
using IMapper = FoodDeliveryApp.Web.Managers.Contracts.IMapper;

namespace FoodDeliveryApp.Web.Managers.Implementation
{
    public class Mapper : IMapper
    {
        private readonly AutoMapper.Mapper _mapper;

        public Mapper()
        {
            _mapper = new AutoMapper.Mapper(GetMapperConfig());
        }

        private IConfigurationProvider GetMapperConfig()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Entities.Restaurant, Models.Restaurant>();
                cfg.CreateMap<Entities.Score, Models.Score>();
                cfg.CreateMap<Entities.Menu, Models.Menu>();
                cfg.CreateMap<Entities.MenuCategory, Models.MenuCategory>();
                cfg.CreateMap<Entities.Dish, Models.Dish>();
                cfg.CreateMap<Entities.FoodCategory, Models.FoodCategory>().ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Type));
            });

            return config;
        }

        public TDest Map<TSource, TDest>(TSource source)
        {
            return _mapper.Map<TDest>(source);
        }
    }
}
