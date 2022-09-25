using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Ordering.Application.Behaviours;
using System.Reflection;

namespace Ordering.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());//This Will Look for class which is Inheriting from Profile in our case MappingProfile
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());//This Will Look for class which is Inheriting from AbstractValidator
            services.AddMediatR(Assembly.GetExecutingAssembly());//This Will Look for class which is Inheriting from IRequestHandler    

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));

            return services;
        }
    }
}