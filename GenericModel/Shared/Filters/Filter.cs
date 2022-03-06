namespace GenericModel.Shared.Filters;
public class Filter
{
  public string? Name { get; set; } = null;
  public IEnumerable<object> FilterOptions { get; set; } = new List<FilterOption>();
}

public class FilterOptionValueType<T> : FilterOption
where T : struct
{
  public T? Value { get; set; }
}

public class FilterOptionString : FilterOption
{
  public string? Value { get; set; }
}

public class FilterOption
{
  public string? Name { get; set; }
  public int Count { get; set; }
}