using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace TheatreShowsAPI.HealthChecks
{
    public class DegradedHealthCheck : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(
            HealthCheckContext context,
            CancellationToken cancellationtoken = default)
        {
            return Task.FromResult(HealthCheckResult.Degraded("The API is experiencing some issues."));
        }
    }
}
