using Microsoft.Extensions.DependencyInjection;
using Safak.Core.Utilities.Ioc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Safak.Core.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection addDependencyResolvers(this IServiceCollection services, ICoreModule[] modules)
        {
            foreach (var module in modules)
            {
                module.Load(services);
            }

            return ServiceTool.Create(services);
        }
    }
}
