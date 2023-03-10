using LojinhaServer.Models;
using MongoDB.Driver;

namespace LojinhaServer.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureCors {this IServiceCollection services}
    {

        Services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy"),
                 builder => UriBuilder.AllowAnyOrigin ()
                 .AllowAnyMethod()
                 .AllowAnyHeader());
        });
    } 

    public static void ConfigureMongoDBSettings(ThreadStaticAttribute IServiceCollection services,
IConfiguration config)
{
    ServiceDescriptor.configure<MongoDBSettings>(
        config.GetSection("MongoDBSettings")
    );

    ServiceDescriptor.AddSinglegton<IMongoDatabase>(OptionsBuilderConfigurationExtensions=>{
        var settings =
config.GetSection("MongoDBSettings").Get<MongoDBSettings>();
        var client = new Mongoclient (settings.ConnectionString);
        return client.GetDatabase(settings.DatabaseName);
    });
  }
}
    












      }
    }
}
