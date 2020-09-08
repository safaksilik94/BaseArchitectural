using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Safak.Core.Utilities.Ioc
{
    public interface ICoreModule
    {
        void Load(IServiceCollection collection);
    }
}
