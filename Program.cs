var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
var app = builder.Build();

app.UseRouting();
app.UseStaticFiles();
app.UseDefaultFiles();

app.MapRazorPages();

app.Run();
