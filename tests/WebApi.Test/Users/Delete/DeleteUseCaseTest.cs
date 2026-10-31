using FluentAssertions;
using System.Net;

namespace WebApi.Test.Users.Delete;

public class DeleteUseCaseTest : CashFlowClassFixture
{
    private const string METHOD = "api/user";

    private readonly string _token;

    public DeleteUseCaseTest(CustomWebApplicationFactory webApplicationFactory) : base(webApplicationFactory)
    {
        _token = webApplicationFactory.User_Team_Member.GetToken();
    }

    [Fact]
    public async Task Success()
    {
        var result = await DoDelete(METHOD, _token);

        result.StatusCode.Should().Be(HttpStatusCode.NoContent);
    }
}
