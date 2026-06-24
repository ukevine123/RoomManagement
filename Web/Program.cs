using RoomManagement.Components;
using Infrastructure.DependencyInjection;
using MudBlazor.Services;
using Application.Services.RoomCategoryService;
using Application.Services.RoomService;
using Application.Services.GuestService;
using Application.Services.BookingService;
using Application.Interface;
using Application.Services.AllocationService;
using Application.Services.PaymentService;
using Application.Services.PaymentTypeService;

var builder = WebApplication.CreateBuilder(args);


// Add Infrastructure Services (DbContext, Repositories, etc.)
builder.Services.AddInfrastructureService(builder.Configuration);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddMudServices();


// Add other services like Booking Services, etc. here if needed.
builder.Services.AddScoped<IRoomCategoryService, RoomCategoryService>();
builder.Services.AddScoped<IRoomService, RoomService>();
builder.Services.AddScoped<IGuestService, GuestService>();
builder.Services.AddScoped<IBookingService, BookingService>();
builder.Services.AddScoped<IAllocationService, AllocationService>();
builder.Services.AddScoped<IPaymentService, PaymentService>();
builder.Services.AddScoped<IPaymentTypeService, PaymentTypeService>();
var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
