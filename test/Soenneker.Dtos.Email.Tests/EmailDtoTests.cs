using Soenneker.Tests.HostedUnit;

namespace Soenneker.Dtos.Email.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class EmailDtoTests : HostedUnitTest
{
    public EmailDtoTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {
    }
}
