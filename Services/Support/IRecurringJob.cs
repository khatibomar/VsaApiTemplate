namespace VsaApiTemplate.Support;

public interface IRecurringJob
{
	Task Execute(CancellationToken cancellationToken);
}
