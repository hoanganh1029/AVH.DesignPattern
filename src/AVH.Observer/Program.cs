using AVH.Observer.Consumers;
using AVH.Observer.Consumers.Products;
using AVH.Observer.Data;
using AVH.Observer.Events;
using NToastNotify;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>();

builder.Services.AddScoped<IEventPublisher, EventPublisher>();
builder.Services.AddScoped<IConsumer<ProductEvent>, ProductEmailNotification>();
builder.Services.AddScoped<IConsumer<ProductEvent>, ProductSMSNotification>();

builder.Services.AddMvc().AddNToastNotifyToastr();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseNToastNotify();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Product}/{action=Index}/{id?}");

app.Run();
