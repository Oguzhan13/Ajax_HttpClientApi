var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// *Inject IoC container
builder.Services.AddSingleton<IPersonRepository, PersonRepository>();
// *Cors and Policy for access API
builder.Services.AddCors(x => x.AddPolicy("myCors", x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
/* Cors */
app.UseCors("myCors");          
/* or don't builder.Services.AddCors(...), do just like this:
app.UseCors(builder =>
{
    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
});
*/
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
