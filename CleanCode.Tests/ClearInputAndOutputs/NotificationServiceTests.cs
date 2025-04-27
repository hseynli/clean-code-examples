using CleanCode.CleanCode.ClearInputAndOutputs;
using CleanCode.Common;

namespace CleanCode.Tests.ClearInputAndOutputs;

public class NotificationServiceTests
{
    // Existing tests...
    // ...

    /// <summary>
    /// Tests the behavior of the SendNotification method when the notification type is SMS.
    /// </summary>
    [Fact]
    public void Should_return_true_when_sending_sms_notification()
    {
        // Arrange
        var service = new NotificationService();
        var customer = new Customer() { Phone = "1234567890" };

        // Act
        var notificationSent = service.SendNotification(customer, NotificationType.Sms, "Your order is ready", "Order Update");

        // Assert
        Assert.True(notificationSent);
    }

    /// <summary>
    /// Tests the behavior of the SendNotification method when the notification is urgent.
    /// </summary>
    [Fact]
    public void Should_return_true_when_sending_urgent_notification()
    {
        // Arrange
        var service = new NotificationService();
        var customer = new Customer() { Phone = "1234567890" };

        // Act
        var notificationSent = service.SendUrgentNotification(customer, NotificationType.Email, "Urgent update", "Urgent Header");

        // Assert
        Assert.True(notificationSent);
    }

    /// <summary>
    /// Tests the behavior of the SendNotification method when the header is null.
    /// </summary>
    [Fact]
    public void Should_throw_exception_when_header_is_null()
    {
        // Arrange
        var service = new NotificationService();
        var customer = new Customer();

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() =>
            service.SendNotification(customer, NotificationType.Email, "Content", null));
    }

    /// <summary>
    /// Tests the behavior of the SendNotification method when an unknown notification type is used.
    /// </summary>
    [Fact]
    public void Should_return_false_when_notification_type_is_unknown()
    {
        // Arrange
        var service = new NotificationService();
        var customer = new Customer();

        // Act
        var notificationSent = service.SendNotification(customer, (NotificationType)999, "Content", "Header");

        // Assert
        Assert.False(notificationSent);
    }

    //-------------------------------------------------------------------------------
    [Fact]
    public void Should_return_false_when_email_is_empty()
    {
        var service = new NotificationService();
        var order = new Order();
        var customer = new Customer()
        {
            Email = ""
        };

        var deliveryResult = service.SendDeliveryUpdate(order, customer);

        Assert.False(deliveryResult.IsSuccess);
        Assert.Equal("Email is required", deliveryResult.Error!.Value.Message);
    }

    [Fact]
    public void Should_return_false_when_email_is_invalid()
    {
        var service = new NotificationService();
        var order = new Order();
        var customer = new Customer()
        {
            Email = "gui"
        };

        var deliveryResult = service.SendDeliveryUpdate(order, customer);

        Assert.False(deliveryResult.IsSuccess);
        Assert.Equal("Invalid email", deliveryResult.Error!.Value.Message);
    }

    [Fact]
    public void Should_throw_argument_null_exception_when_order_is_null()
    {
        var service = new NotificationService();
        var customer = new Customer();

        var exception = Assert.Throws<ArgumentNullException>(() => service.SendDeliveryUpdate(null!, customer));

        Assert.Equal("order", exception.ParamName);
    }

    [Fact]
    public void Should_throw_argument_null_exception_when_customer_is_null()
    {
        var service = new NotificationService();

        var exception = Assert.Throws<ArgumentNullException>(() => service.SendDeliveryUpdate(new Order(), null!));

        Assert.Equal("customer", exception.ParamName);
    }

    //-------------------------------------------------------------------------------
}
