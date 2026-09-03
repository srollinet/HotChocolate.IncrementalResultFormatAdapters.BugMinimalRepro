var builder = WebApplication.CreateBuilder(args);

builder
    .AddGraphQL()
    .AddTypes()
    .ModifyOptions(options => { options.EnableDefer = true; });

var app = builder.Build();

app.MapGraphQL();

app.RunWithGraphQLCommands(args);