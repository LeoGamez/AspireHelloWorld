namespace HelloWorldApire.Web.Services;

public interface IHelloWorldClient
{
    Task<string> GetHelloWorld(CancellationToken cancellationToken = default);
}

public class HelloWorldClient(HttpClient httpClient) : IHelloWorldClient
{
    public async Task<string> GetHelloWorld(CancellationToken cancellationToken = default)
    {
        string result = "";
        result = await httpClient.GetStringAsync("/helloworld", cancellationToken);
        return result;
    }
}

