using AuthService.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var _googleAPIData = LoadJson() ?? throw new FileNotFoundException();
builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
})
    .AddCookie(options =>
    {
        options.LoginPath = "/account/google-login";
    })
    .AddGoogle(options =>
    {
        options.ClientId = _googleAPIData.ClientId;
        options.ClientSecret = _googleAPIData.ClientSecret;
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

static GoogleAPIData? LoadJson()
{
    using (StreamReader r = new StreamReader("GoogleAPIData.json"))
    {
        string json = r.ReadToEnd();
        return JsonConvert.DeserializeObject<GoogleAPIData>(json);
    }
}