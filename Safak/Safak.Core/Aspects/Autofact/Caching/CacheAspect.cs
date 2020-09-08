using Castle.DynamicProxy;
using Safak.Core.CrossCuttingConcerns.Caching;
using Safak.Core.Utilities.Interceptors;
using Safak.Core.Utilities.Ioc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Safak.Core.Aspects.Autofact.Caching
{
    public class CacheAspect:MethodInterception
    {
        private int _Duration;
        private ICacheManager _cacheManger;

        //Default value=60 minutes;
        public CacheAspect(int duraiton=60)
        {
            _Duration = duraiton;
            _cacheManger = ServiceTool.ServiceProvider.GetService<ICacheManager>();
        }
        public override void Intercept(IInvocation invocation)
        {
            var methodName = string.Format($"{invocation.Method.ReflectedType.FullName}.{invocation.Method.Name}");
            var argument = invocation.Arguments.ToList();
            var key = $"{methodName}({string.Join(",",argument.Select(x=>x?.ToString()??"<Null>"))})";
            if (_cacheManger.IsAdd(key))
            {
                invocation.ReturnValue = _cacheManger.Get(key);
                return;
            }
            invocation.Proceed();
            _cacheManger.Add(key, invocation.ReturnValue, _Duration);
        }
    }
}
