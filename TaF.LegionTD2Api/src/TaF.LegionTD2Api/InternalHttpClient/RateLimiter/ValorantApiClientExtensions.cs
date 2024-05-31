using System;

namespace TaF.LegionTD2Api.InternalHttpClient.RateLimiter;

public static class ValorantApiClientExtensions
{
    public static void SetRateLimiter(this InternalClient client, RateLimiterSettings rateLimiterSettings)
    {
        if (client == null)
        {
            throw new ArgumentException("You must supply a valid client", nameof(client));
        }

        if (rateLimiterSettings == null)
        {
            throw new ArgumentException("You must supply a valid RateLimiterSettings", nameof(rateLimiterSettings));
        }

        rateLimiterSettings.EnableRateLimiter(client);
    }

    public static void UnsetRateLimiter(this InternalClient client, RateLimiterSettings rateLimiterSettings)
    {
        if (client == null)
        {
            throw new ArgumentException("You must supply a valid client", nameof(client));
        }

        if (rateLimiterSettings == null)
        {
            throw new ArgumentException("You must supply a valid RateLimiterSettings", nameof(rateLimiterSettings));
        }

        rateLimiterSettings.DisableRateLimiter(client);
    }
}