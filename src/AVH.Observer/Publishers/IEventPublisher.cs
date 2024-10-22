namespace AVH.Observer.Events;

public interface IEventPublisher
{
	Task PublishAsync<T>(T eventMessage);
}
