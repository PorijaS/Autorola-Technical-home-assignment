using System.Text.Json.Serialization;

namespace Autorola_Technical_home_assignment.Data
{
    public class FilterData
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public class Filter
    {
        public string Name { get; set; }
        public List<FilterData> Data { get; set; }
    }

    public class FilterResponse
    {
        public List<Filter> Filters { get; set; }
        public int Count { get; set; }
    }
}
