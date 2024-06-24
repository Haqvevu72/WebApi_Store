using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Store.Application.Services.Abstract;
using Store.Application.Services.Concrete;
using Store.Domain.Repository_Interfaces.Category;
using Store.Domain.Repository_Interfaces.Invoice;
using Store.Domain.Repository_Interfaces.InvoiceItems;
using Store.Domain.Repository_Interfaces.Product;
using Store.Domain.Repository_Interfaces.Role;
using Store.Domain.Repository_Interfaces.User;
using Store.Domain.Repository_Interfaces.UserToken;
using Store.Persistence.Database;
using Store.Persistence.Repository_Implementations.Category;
using Store.Persistence.Repository_Implementations.Invoice;
using Store.Persistence.Repository_Implementations.InvoiceItem;
using Store.Persistence.Repository_Implementations.Product;
using Store.Persistence.Repository_Implementations.Role;
using Store.Persistence.Repository_Implementations.User;
using Store.Persistence.Repository_Implementations.UserToken;

namespace Store.Persistence;

public static class RegisterService
{
    public static void AddPersistenceRegister(this IServiceCollection services)
    {
        services.AddDbContext<StoreDb>(options =>
        {
            // Register Database
            ConfigurationBuilder configurationBuilder = new();
            var builder = configurationBuilder.AddJsonFile("appsettings.json").Build();

            options.UseLazyLoadingProxies().UseSqlServer(builder.GetConnectionString("default"));
            
        });
        
        // Register Repositories
        // |    
        // |__ // Read Repositories 
        services.AddScoped<IReadProductRepository, ReadProductRepository>();
        services.AddScoped<IReadCategoryRepository, ReadCategoryRepository>();
        services.AddScoped<IReadInvoiceRepository, ReadInvoiceRepository>();
        services.AddScoped<IReadInvoiceItemRepository, ReadInvoiceItemRepository>();
        services.AddScoped<IReadUserRepository, ReadUserRepository>();
        services.AddScoped<IReadUserTokenRepository, ReadUserTokenRepository>();
        services.AddScoped<IReadRoleRepository, ReadRoleRepository>();
        // |    
        // |        
        // |__ // Write Repositories
        services.AddScoped<IWriteProductRepository, WriteProductRepository>();
        services.AddScoped<IWriteCategoryRepository, WriteCategoryRepository>();
        services.AddScoped<IWriteInvoiceRepository, WriteInvoiceRepository>();
        services.AddScoped<IWriteInvoiceItemRepository, WriteInvoiceItemRepository>();
        services.AddScoped<IWriteUserRepository, WriteUserRepository>();
        services.AddScoped<IWriteUserTokenRepository, WriteUserTokenRepository>();
        services.AddScoped<IWriteRoleRepository, WriteRoleRepository>();
                
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IInvoiceService, InvoiceService>();
        services.AddScoped<IRoleService, RoleService>();
    }
}