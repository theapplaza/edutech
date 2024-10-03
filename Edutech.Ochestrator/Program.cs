var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Edutech_Api>("Api");

builder.Build().Run();
