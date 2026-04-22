using Soenneker.Tests.HostedUnit;

namespace Soenneker.Fly.Machines.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class FlyMachinesOpenApiClientRunnerTests : HostedUnitTest
{
    public FlyMachinesOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
