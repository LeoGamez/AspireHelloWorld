var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.HelloWorldApire_ApiService>("apiservice");

builder.AddProject<Projects.HelloWorldApire_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
