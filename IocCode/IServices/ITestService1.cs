using IocCode.Services;
using SimpleIoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocCode.IServices
{
    public interface ITestService1
    {
        void Action();
    }

    public static class ITestService1Extension
    {
        public static IServiceCollection AddTestService1(this IServiceCollection services)
        {
            services.AddTransient<ITestService1, TestService1>();
            return services;
        }
    }

    public interface ITestService2
    {
        void Action();
    }

    public static class ITestService2Extension
    {
        public static IServiceCollection AddTestService2(this IServiceCollection services)
        {
            services.AddTransient<ITestService2, TestService2>();
            return services;
        }
    }

    public interface ITestService3
    {
        void Action();
    }

    public static class ITestService3Extension
    {
        public static IServiceCollection AddTestService3(this IServiceCollection services)
        {
            services.AddTransient<ITestService3, TestService3>();
            return services;
        }
    }
}
