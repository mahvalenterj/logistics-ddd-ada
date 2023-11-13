using FluentValidation;

var builder = WebApplication.CreateBuilder(args);

// Adicione serviços ao contêiner.
// Configurando nossa camada de persistência
builder.Services.ConfigurePersistenceApp(builder.Configuration);

// Registrar os serviços relacionados à camada de aplicação
// auto mapper, mediator, fluent id
builder.Services.ConfigureApplicationApp();
builder.Services.ConfigureCorsPolicy();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Obtém o serviço provider após a construção da aplicação
var serviceProvider = app.Services;

// Obtenha o validador requerido
//var validator = serviceProvider.GetRequiredService<IValidator<CreatePurchaseNotificationRequest>>();

// Agora você pode fazer o que precisa com o validador, se necessário

// Esse método precisamos criar manualmente para subir nosso BD à nossa aplicação
BD.CreateDatabase(app);

app.UseSwagger();
app.UseSwaggerUI();

app.UseCors();
app.MapControllers();
app.Run();
