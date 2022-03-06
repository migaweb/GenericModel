using AutoMapper;
using GenericModel.Shared.Filters;

namespace GenericModel.Server.Configuration;
public class MapperInitializer : Profile
{
  public MapperInitializer()
  {
    CreateMap<Model.Filter, Filter>().ReverseMap();
    CreateMap<Model.FilterOption, FilterOption> ()
      .Include(typeof(Model.FilterOptionValueType<>), typeof(FilterOptionValueType<>))
      .Include(typeof(Model.FilterOptionString), typeof(FilterOptionString));


    CreateMap(typeof(Model.FilterOptionValueType<>), typeof(FilterOptionValueType<>));
    CreateMap<Model.FilterOptionString, FilterOptionString>();
  }
}

