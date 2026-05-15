using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace TheatreShowsAPI.HealthChecks
{
    public class HealthyHealthCheck: IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(
            HealthCheckContext context,
            CancellationToken cancellationtoken = default)
        {
           return Task.FromResult(HealthCheckResult.Healthy("The API is healthy."));
        }
    }
}
