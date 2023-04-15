using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace AspHeathCheck.HealthCheker;

public class CustomHealthCheck : IHealthCheck
{
    /// <inheritdoc />
    public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
    {
        var isHealthy = true; //set this to false to see Unhealthy result at Mapped Route '/healthz' in Program.cs

        if (isHealthy)
        {
            return Task.FromResult(
                    HealthCheckResult.Healthy("everything is healthy."));
        }

        return Task.FromResult(
                new HealthCheckResult(
                        context.Registration.FailureStatus, "An unhealthy result."));
    }
}