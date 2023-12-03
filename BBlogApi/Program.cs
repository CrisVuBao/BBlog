using BBlogApi.Data;
using BBlogApi.Models;
using BBlogApi.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Net;
using System.Text;
using Microsoft.AspNetCore.Http;
using BBlogApi.Services.IServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddControllers();
builder.Services.AddControllersWithViews();
builder.Services.AddHttpContextAccessor();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    var jwtSecurityScheme = new OpenApiSecurityScheme
    {
        BearerFormat = "JWT",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = JwtBearerDefaults.AuthenticationScheme,
        Description = "Nhập Bearer + token của tài khoản vừa mới đăng nhập",
        Reference = new OpenApiReference
        {
            Id = JwtBearerDefaults.AuthenticationScheme,
            Type = ReferenceType.SecurityScheme
        }
    };

    c.AddSecurityDefinition(jwtSecurityScheme.Reference.Id, jwtSecurityScheme);

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
			jwtSecurityScheme, Array.Empty<string>()
		}      
    });
} 
    
);

builder.Services.AddDbContext<BlogContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CorsPolicy",
        builder => builder
        .SetIsOriginAllowed(host => true)
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials()
        );
});

// Cấu hình Role Identity

builder.Services.AddIdentity<Account, Role>(opt =>
{
    opt.User.RequireUniqueEmail = false;
    opt.SignIn.RequireConfirmedAccount = true;
})
    .AddEntityFrameworkStores<BlogContext>()
    .AddDefaultTokenProviders(); ;


builder.Services.AddAuthentication(options =>
{
	options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
	options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
	options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(opt =>
{
    opt.SaveToken = true;
    opt.TokenValidationParameters = new TokenValidationParameters
                                        {
                                            ValidateIssuer = false,
                                            ValidateAudience = false,
                                            ValidateIssuerSigningKey = true,
											IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:SecretKey"]))
                                        };
});

builder.Services.AddAuthorization();

builder.Services.AddScoped<TokenService>();
builder.Services.AddScoped<ImageService>();

// đk automapper để sử dụng
builder.Services.AddAutoMapper(typeof(Program));

// Life cycle DI: AddScoped()
builder.Services.AddScoped<IPostRepository, PostRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(opt =>
{
    opt.AllowAnyHeader().AllowAnyMethod().AllowCredentials().WithOrigins("http://localhost:3000");
});

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
var scope = app.Services.CreateScope();
var context = scope.ServiceProvider.GetRequiredService<BlogContext>();
var userManager = scope.ServiceProvider.GetRequiredService<UserManager<Account>>();
var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();

try
{
    await context.Database.MigrateAsync();
    await DbInitializer.Inittialize(userManager);
}
catch (Exception ex)
{
    logger.LogError(ex, "A problem with migration for database");
}

app.Run();
