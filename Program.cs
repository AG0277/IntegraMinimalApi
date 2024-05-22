using IntegraMinimalApi;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MinimalApiDb>(opt => opt.UseInMemoryDatabase("TodoList"));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

var app = builder.Build();
app.UseDeveloperExceptionPage();

app.MapGet("/appuser", async (MinimalApiDb db) =>
{
    var appUsers = await db.AppUsers.ToListAsync();
    return appUsers != null && appUsers.Count != 0 ? Results.Ok(appUsers) : Results.NotFound();
});

app.MapGet("/appuser/{id}", async (int id, MinimalApiDb db) =>
{
    var appUser = await db.AppUsers.FirstOrDefaultAsync(a => a.Id == id);
    return appUser != null ? Results.Ok(appUser) : Results.NotFound();
});

app.MapPost("/appuser", async (AppUserDto appUserDto, MinimalApiDb db) =>
{
    var appUser = appUserDto.AppUserDtoToAppUser();
    var createdAppUser = await db.AppUsers.AddAsync(appUser);
    await db.SaveChangesAsync();

    return Results.Created($"/appuser/{appUser.Id}", appUser);
});


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();

