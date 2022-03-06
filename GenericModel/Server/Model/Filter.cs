namespace GenericModel.Server.Model;
public class Filter
{
  public Filter(string name, IEnumerable<FilterOption> filterOptions)
  {
    Name = name;
    FilterOptions = filterOptions;
  }

  public string Name { get; set; }
  public IEnumerable<FilterOption> FilterOptions { get; set; }
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

public abstract class FilterOption
{
  public string? Name { get; set; }
  public int Count { get; set; }
}
