using CleanCode.SeperationOfConstructionAndLogic;

namespace CleanCode.Tests.SeperationOfConstructionAndLogic;

public class NotificationServiceTests
{
    [Fact]
    public void Should_send_as_html_when_using_exchange()
    {
        var notificationFormat = NotificationFormat.Create("Exchange");

        Assert.True(notificationFormat.Html);
    }
}
