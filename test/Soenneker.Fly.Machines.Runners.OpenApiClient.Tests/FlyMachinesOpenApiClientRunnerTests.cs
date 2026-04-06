using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Fly.Machines.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class FlyMachinesOpenApiClientRunnerTests : FixturedUnitTest
{
    public FlyMachinesOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
