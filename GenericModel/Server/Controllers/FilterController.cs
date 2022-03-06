using AutoMapper;
using GenericModel.Shared.Filters;
using Microsoft.AspNetCore.Mvc;

namespace GenericModel.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class FilterController : ControllerBase
{
  private readonly IMapper _mapper;

  public FilterController(IMapper mapper)
  {
    _mapper = mapper;
  }

  [HttpGet]
  public IActionResult Get()
  {
    var filters = new List<Model.Filter>();

    filters.Add(new Model.Filter("Drinks", new List<Model.FilterOptionString>() {
      new () { Count = 1, Name = "Fanta", Value = "Fanta" },
      new () { Count = 1, Name = "Sprite", Value = "Sprite" },
    }));

    filters.Add(new Model.Filter("Prices", new List<Model.FilterOptionValueType<decimal>>() {
      new () { Count = 1, Name = "12,5", Value = 12.5M },
      new () { Count = 1, Name = "20", Value = 20M },
    }));

    filters.Add(new Model.Filter("Diameter", new List<Model.FilterOptionValueType<int>>() {
      new () { Count = 1, Name = "34", Value = 34 },
      new () { Count = 1, Name = "102", Value = 102 },
    }));

    var mappedResult = _mapper.Map<List<Filter>>(filters);
    return Ok(mappedResult);
  }
}
