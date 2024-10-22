namespace AVH.Observer.Consumers;

public interface IConsumer<T>
{
	Task HandleEventAsync(T eventMessage);
}
