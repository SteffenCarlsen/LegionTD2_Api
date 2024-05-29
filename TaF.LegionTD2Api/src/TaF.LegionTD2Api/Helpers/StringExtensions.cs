using System;

namespace TaF.LegionTD2Api.Helpers;

public static class StringExtensions
{
    public static string ToQueryDateString(this DateTime time)
    {
        return time.ToString("yyyy-MM-dd HH:mm:ss");
    }
}