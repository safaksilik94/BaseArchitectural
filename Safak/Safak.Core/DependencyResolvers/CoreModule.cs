using Microsoft.Extensions.DependencyInjection;
using Safak.Core.CrossCuttingConcerns.Caching;
using Safak.Core.CrossCuttingConcerns.Caching.Microsoft;
using Safak.Core.Utilities.Ioc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Safak.Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection services)
        {
            services.AddMemoryCache();
            services.AddSingleton<ICacheManager,MemoryCacheManager>();
        }
    }
}
