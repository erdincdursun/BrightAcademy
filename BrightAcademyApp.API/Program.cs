using BrightAcademyApp.Business.Abstract;
using BrightAcademyApp.Business.Concrete;
using BrightAcademyApp.Data.Abstract;
using BrightAcademyApp.Data.Concrete.EntityFramework.Contexts;
using BrightAcademyApp.Data.Concrete.EntityFramework.Repositories;
using BrightAcademyApp.Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<BrightAcademyAppDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection")));


builder.Services.AddScoped<ICourseService, CourseManager>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();

builder.Services.AddScoped<ICourseRepository, EfCoreCourseRepository>();
builder.Services.AddScoped<ICategoryRepository, EfCoreCategoryRepository>();


builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<BrightAcademyAppDbContext>()
    .AddDefaultTokenProviders();
builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    options.Password.RequiredLength = 6;
    options.Password.RequireNonAlphanumeric = true;

    options.Lockout.MaxFailedAccessAttempts = 3; 
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);

    options.User.RequireUniqueEmail = true;

    options.SignIn.RequireConfirmedEmail = false;
    options.SignIn.RequireConfirmedPhoneNumber = false; 
});


builder.Services.AddCors(options =>
{
    options.AddPolicy(
        name: "_allowAllPolicy",
        policy =>
        {
            policy
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
        }
    );
});

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
