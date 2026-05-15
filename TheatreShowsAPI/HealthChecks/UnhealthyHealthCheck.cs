using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace TheatreShowsAPI.HealthChecks
{
    public class UnhealthyHealthCheck : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(
            HealthCheckContext context,
            CancellationToken cancellationtoken = default)
        {
            return Task.FromResult(HealthCheckResult.Unhealthy("The API is unhealthy."));
        }
    }
}
