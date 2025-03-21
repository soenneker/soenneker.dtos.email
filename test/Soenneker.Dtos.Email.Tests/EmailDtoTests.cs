using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Dtos.Email.Tests;

[Collection("Collection")]
public class EmailDtoTests : FixturedUnitTest
{
    public EmailDtoTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {
    }
}
