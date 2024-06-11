using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Repository;
using Repository.Entity;
using Repository.IRepository;
using Repository.Repository;
using Service.IService;
using Service.Service;
using System.Globalization;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

#region Define: multi language

// Multi language
// https://tutorials.eu/building-a-multi-language-site-in-asp-net-core/
builder.Services.AddControllersWithViews().AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix);
builder.Services.AddLocalization(options => options.ResourcesPath = "AppResources"); //The path in which you store the resources.
builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    var supportedCultures = new[]
    {
        new CultureInfo("vi-VN"),
		// new CultureInfo("fr-FR"),
	};

    options.DefaultRequestCulture = new RequestCulture("vi-VN");
    options.SupportedUICultures = supportedCultures;
});


#endregion

#region Define: DbContext

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDBContext>(options =>
{
    options.UseSqlServer(connectionString);
});


#endregion

#region Define: Service Injection
//builder.Services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>().AddDefaultUI().AddDefaultTokenProviders();
//var automapper = new MapperConfiguration(item => item.AddProfile(new AutoMapperHandler()));
//IMapper mapper = automapper.CreateMapper();
//builder.Services.AddSingleton(mapper);
builder.Services.AddSignalR();


builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IData_MenuService, Data_MenuService>();
builder.Services.AddScoped<IData_MenuRepository, Data_MenuRepository>();
builder.Services.AddScoped<IErrorMachineService, ReportErrorMachineService>();

builder.Services.AddScoped<IReportMachineRuningStatusService, ReportMachineRuningStatusService>();
builder.Services.AddScoped<IRazorPartialToStringRenderer, RazorPartialToStringRenderer>();
builder.Services.AddScoped<IDashboardService, DashboardService>();
builder.Services.AddScoped<IMachineManagementService, MachineManagementService>();
builder.Services.AddScoped<IData_ErrorRepository, Data_ErrorRepository>();
builder.Services.AddScoped<IData_ErrorService, Data_ErrorService>();

#endregion

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

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.MapControllerRoute(
    name: "default",
// pattern: "{controller=Home}/{action=Index}/{id?}");
// pattern: "{controller=Authentication}/{action=LoginForm}/{id?}");
// pattern: "{controller=ReportErrorMachine}/{action=Index}/{id?}");

// pattern: "{controller=ReportMachineRuningStatus}/{action=Index}/{id?}");
// pattern: "{controller=ReportMachineRuningStatus}/{action=Detail}/{id?}");
// pattern: "{controller=Dashboard}/{action=Index}/{id?}");
// pattern: "{controller=MachineManagement}/{action=Index}/{id?}");
pattern: "{controller=ReportMachineRuningStatus}/{action=Layout1}");

app.UseRequestLocalization();

// ============================================= //
app.Run();
// ============================================= //

