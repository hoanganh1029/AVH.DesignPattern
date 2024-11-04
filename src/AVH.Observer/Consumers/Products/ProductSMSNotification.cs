using AVH.Observer.Events;
using NToastNotify;

namespace AVH.Observer.Consumers.Products;

public class ProductSMSNotification : IConsumer<ProductEvent>
{
    //NOTE: The _toastNotification is an scoped service that could not be used in Singleton consumer
    private readonly IToastNotification _toastNotification;

    public ProductSMSNotification(IToastNotification toastNotification)
    {
        _toastNotification = toastNotification;
    }

    public Task HandleEventAsync(ProductEvent eventMessage)
    {
        // Log the product creation event
        var message = $"Product '{eventMessage.Code} - {eventMessage.Name}' was published. SMS have been sent successfully.";
        Console.WriteLine(message);

        _toastNotification.AddInfoToastMessage(message);
        return Task.CompletedTask;
    }
}
