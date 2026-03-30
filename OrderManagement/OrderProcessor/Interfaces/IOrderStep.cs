namespace OrderProcessor.Interfaces;

public interface IOrderStep
{
    Task ExecuteAsync(IOrderContext context, CancellationToken cancellationToken = default);
}