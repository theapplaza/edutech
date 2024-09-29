var builder = DistributedApplication.CreateBuilder(args);

var Api = builder.AddProject<Projects.Edutech_Api>("Api");

builder.AddProject<Projects.Edutech_Frontend>("Frontend").WithReference(Api);

builder.Build().Run();
