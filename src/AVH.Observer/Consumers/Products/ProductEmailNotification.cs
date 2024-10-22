using AVH.Observer.Events;
using NToastNotify;

namespace AVH.Observer.Consumers.Products;

public class ProductEmailNotification : IConsumer<ProductEvent>
{
    //NOTE: The _toastNotification is an scoped service that could not be used in Singleton consumer
    private readonly IToastNotification _toastNotification;

    public ProductEmailNotification(IToastNotification toastNotification)
    {
        _toastNotification = toastNotification;
    }

    public Task HandleEventAsync(ProductEvent eventMessage)
    {
        // Log the product creation event
        var message = $"Product '{eventMessage.Code} - {eventMessage.Name}' was published. Emails have been sent successfully.";
        Console.WriteLine(message);

        _toastNotification.AddSuccessToastMessage(message);
        return Task.CompletedTask;
    }
}
