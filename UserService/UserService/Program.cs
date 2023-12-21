using Microsoft.AspNetCore.Authentication.Cookies;
using Newtonsoft.Json;
using UserService.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var _googleAPIData = LoadJson();
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
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

GoogleAPIData LoadJson()
{
    using (StreamReader r = new StreamReader("GoogleAPIData.json"))
    {
        string json = r.ReadToEnd();
        return JsonConvert.DeserializeObject<GoogleAPIData>(json);
    }
}
