using LoginSystemApi.Data;

var builder = WebApplication.CreateBuilder(args);
/* adicionando services */
builder.Services.AddControllers();
builder.Services.AddDbContext<AppDataContext>();

var app = builder.Build();
/* mapeando controllers */
app.MapControllers();

app.Run();
