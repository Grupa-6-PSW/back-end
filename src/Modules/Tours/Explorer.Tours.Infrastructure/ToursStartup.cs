using Explorer.BuildingBlocks.Core.UseCases;
using Explorer.BuildingBlocks.Infrastructure.Database;
using Explorer.Tours.API.Public.Administration;
using Explorer.Tours.API.Public.Marketplace;
using Explorer.Tours.API.Public.TourExecuting;
using Explorer.Tours.Core.Domain;
using Explorer.Tours.Core.Domain.RepositoryInterfaces;
using Explorer.Tours.Core.Domain.TourExecutions;
using Explorer.Tours.Core.Domain.Tours;
using Explorer.Tours.Core.Mappers;
using Explorer.Tours.Core.UseCases.Administration;
using Explorer.Tours.Core.UseCases.Authoring;
using Explorer.Tours.Core.UseCases.Marketplace;
using Explorer.Tours.Core.UseCases.TourExecuting;
using Explorer.Tours.Infrastructure.Database;
using Explorer.Tours.Infrastructure.Database.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Explorer.Tours.Infrastructure;

public static class ToursStartup
{
    public static IServiceCollection ConfigureToursModule(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(ToursProfile).Assembly);
        SetupCore(services);
        SetupInfrastructure(services);
        return services;
    }
    
    private static void SetupCore(IServiceCollection services)
    {
        services.AddScoped<IEquipmentService, EquipmentService>();



        services.AddScoped<ITouristEquipmentService, TouristEquipmentService>();



        services.AddScoped<ITourReviewService, TourReviewService>();


        services.AddScoped<ITourObjectService, TourObjectService>();
        services.AddScoped<IObjInTourService, ObjInTourService>();
        services.AddScoped<ITourService, TourService>();
        services.AddScoped<ITourEquipmentService,TourEquipmentService>();
        services.AddScoped<ITourPointService, TourPointService>();
        services.AddScoped<IGuideReviewService, GuideReviewService>();
        services.AddScoped<IPreferencesService, PreferencesService>();
        services.AddScoped<ITourExecutionService, TourExecutionService>();
        services.AddScoped<ITourPointExecutionService, TourPointExecutionService>();
        services.AddScoped<ITourExecutionPositionService, TourExecutionPositionService>();

        


    }

    private static void SetupInfrastructure(IServiceCollection services)
    {
        services.AddScoped(typeof(ICrudRepository<Equipment>), typeof(CrudDatabaseRepository<Equipment, ToursContext>));



        services.AddScoped(typeof(ICrudRepository<TouristEquipment>), typeof(CrudDatabaseRepository<TouristEquipment, ToursContext>));


        


        services.AddScoped(typeof(ICrudRepository<TourReview>), typeof(CrudDatabaseRepository<TourReview, ToursContext>));


        services.AddScoped(typeof(ICrudRepository<TourObject>), typeof(CrudDatabaseRepository<TourObject, ToursContext>));
        services.AddScoped(typeof(ICrudRepository<ObjInTour>), typeof(CrudDatabaseRepository<ObjInTour, ToursContext>));

        services.AddScoped(typeof(ICrudRepository<Tour>), typeof(CrudDatabaseRepository<Tour, ToursContext>));
        services.AddScoped(typeof(ICrudRepository<TourEquipment>), typeof(CrudDatabaseRepository<TourEquipment, ToursContext>));
        services.AddScoped(typeof(ICrudRepository<TourPoint>), typeof(CrudDatabaseRepository<TourPoint, ToursContext>));

        services.AddScoped(typeof(ICrudRepository<GuideReview>), typeof(CrudDatabaseRepository<GuideReview, ToursContext>));
        services.AddScoped(typeof(ICrudRepository<Preferences>), typeof(CrudDatabaseRepository<Preferences, ToursContext>));
		services.AddScoped<ITourRepository, TourRepository>();

        services.AddScoped(typeof(ICrudRepository<TourExecution>),typeof(CrudDatabaseRepository<TourExecution,ToursContext>));
        services.AddScoped(typeof(ICrudRepository<TourPointExecution>), typeof(CrudDatabaseRepository<TourPointExecution, ToursContext>));
        services.AddScoped(typeof(ICrudRepository<TourExecutionPosition>), typeof(CrudDatabaseRepository<TourExecutionPosition, ToursContext>));
        services.AddScoped<ITourExecutionRepository, TourExecutionRepository>();




        services.AddDbContext<ToursContext>(opt =>
            opt.UseNpgsql(DbConnectionStringBuilder.Build("tours"),
                x => x.MigrationsHistoryTable("__EFMigrationsHistory", "tours")));
    }
}