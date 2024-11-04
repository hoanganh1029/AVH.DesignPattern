using AVH.Observer.Consumers;

namespace AVH.Observer.Events;

public class EventPublisher : IEventPublisher
{
	private readonly IServiceProvider _serviceProvider;

	public EventPublisher(IServiceProvider serviceProvider)
	{
		_serviceProvider = serviceProvider;
	}

	public async Task PublishAsync<T>(T eventMessage)
	{
		//If the lifetime of the publisher is singleton (longer than consumer) 
		//then error 'Cannot resolve service' occurred.
		//The reason could be the lifetime of the _serviceProvider is singleton that could not get service scope
		var consumers = _serviceProvider.GetServices<IConsumer<T>>();

		foreach (var consumer in consumers)
		{
			// Notify the consumers asynchronously
			await consumer.HandleEventAsync(eventMessage);
		}
	}
}