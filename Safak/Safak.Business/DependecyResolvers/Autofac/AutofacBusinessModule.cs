using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Safak.Business.Abstract;
using Safak.Business.Concrete;
using Safak.Core.Utilities.Interceptors;
using Safak.Core.Utilities.Security.Jwt;
using Safak.DataAccess.Abstract;
using Safak.DataAccess.Concrete.EntiyFramework;
using Safak.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Safak.Business.DependecyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<EfProductDal>().As<IProductDal>();

            builder.RegisterType<CategoriesManager>().As<ICategoriesService>();
            builder.RegisterType<EfCategoriesDal>().As<ICategoriesDal>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
