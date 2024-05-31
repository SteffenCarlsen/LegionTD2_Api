using System.Collections.Generic;
using System.Text;

namespace TaF.LegionTD2Api.Helpers;

public class QueryBuilder
{
    private readonly Dictionary<string, string> _parameters;
    private readonly StringBuilder _queryBuilder;

    public QueryBuilder()
    {
        _queryBuilder = new StringBuilder();
        _parameters = new Dictionary<string, string>();
    }

    public QueryBuilder Add(string key, string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return this;
        }

        _parameters.Add(key, value);
        return this;
    }

    public string Build()
    {
        if (_parameters.Count > 0)
        {
            _queryBuilder.Append("?");
        }

        foreach (var parameter in _parameters)
        {
            if (_queryBuilder.Length > 1)
            {
                _queryBuilder.Append("&");
            }

            _queryBuilder.Append($"{parameter.Key}={parameter.Value}");
        }

        return _queryBuilder.ToString();
    }
}