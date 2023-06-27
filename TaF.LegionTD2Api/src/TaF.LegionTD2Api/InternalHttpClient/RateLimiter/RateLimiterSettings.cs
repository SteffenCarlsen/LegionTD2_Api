using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ComposableAsync;
using RateLimiter;

namespace TaF.LegionTD2Api.InternalHttpClient.RateLimiter
{
    public class RateLimiterSettings
    {
        private readonly List<IAwaitableConstraint> timeLimiters;

        public RateLimiterSettings()
        {
            timeLimiters = new List<IAwaitableConstraint>();
        }

        public void AddRateLimit(IAwaitableConstraint constraint)
        {
            if (constraint == null)
                throw new ArgumentException("You must supply a valid constraint", nameof(constraint));

            timeLimiters.Add(constraint);
        }

        public void AddRateLimit(int amount, TimeSpan time)
        {
            if (amount < 0) throw new ArgumentException("You must supply a valid amount", nameof(amount));

            if (time == null) throw new ArgumentException("You must supply a valid time", nameof(time));

            var constraint = new CountByIntervalAwaitableConstraint(amount, time);
            timeLimiters.Add(constraint);
        }

        public void RemoveRateLimit(IAwaitableConstraint constraint)
        {
            if (constraint == null)
                throw new ArgumentException("You must supply a valid constraint", nameof(constraint));

            timeLimiters.Remove(constraint);
        }

        public void ClearRateLimit()
        {
            timeLimiters.Clear();
        }

        public void EnableRateLimiter(InternalClient client)
        {
            if (client == null) throw new ArgumentException("You must supply a valid client", nameof(client));

            client.BeforeRequestAsync += OnBeforeRequestAsync;
            client.ErrorRequestAsync += OnErrorRequestAsync;
        }

        private async Task OnErrorRequestAsync(object sender, EventArgs e)
        {
            if (sender == null || e == null) return;

            var clientRequest = e as ClientRequestErrorEventArgs;
            if (clientRequest.StatusCode != 200) await TimeLimiter.Compose(timeLimiters.ToArray());
        }

        public void DisableRateLimiter(InternalClient client)
        {
            if (client == null) throw new ArgumentException("You must supply a valid client", nameof(client));

            client.BeforeRequestAsync -= OnBeforeRequestAsync;
            client.ErrorRequestAsync -= OnErrorRequestAsync;
        }

        private async Task OnBeforeRequestAsync(object sender, EventArgs e)
        {
            if (sender == null || e == null) return;

            var clientRequest = e as ClientRequestEventArgs;
            if (string.IsNullOrEmpty(clientRequest.ResponseContent)) await TimeLimiter.Compose(timeLimiters.ToArray());
        }
    }
}