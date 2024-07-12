using Carter;

namespace HelloWorldApire.ApiService.HelloWorld;

public class HelloWorldModule : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/helloworld", () => "Hello World From an API in ASPIRE");
    }
}
