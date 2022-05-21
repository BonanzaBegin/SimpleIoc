// See https://aka.ms/new-console-template for more information
using IocCode.IServices;
using IocCode.Services;
using SimpleIoc;
using SimpleIoc.Extensions;

Console.WriteLine("Hello, World!");


{
    IServiceCollection serviceCollection = new ServiceCollection();


    serviceCollection.AddTransient<ITestService1, TestService1>();
    serviceCollection.AddTransient<ITestService2, TestService2>();
    serviceCollection.AddTransient<ITestService3, TestService3>();

    IServiceProvider provider = serviceCollection.BuildServiceProvider();

    var v11 = provider.GetService<ITestService1>();
    var v12 = provider.GetService<ITestService1>();
    var v21 = provider.GetService<ITestService2>();
    var v22 = provider.GetService<ITestService2>();
    var v31 = provider.GetService<ITestService3>();
    var v32 = provider.GetService<ITestService3>();

    bool flag1 = object.ReferenceEquals(v11, v12);
    bool flag2 = object.ReferenceEquals(v21, v22);
    bool flag3 = object.ReferenceEquals(v31, v32);

    Console.WriteLine(flag1);
    Console.WriteLine(flag2);
    Console.WriteLine(flag3);
}
Console.WriteLine("**************************************************");

{
    IServiceCollection serviceCollection = new ServiceCollection();


    serviceCollection.AddSingleton<ITestService1, TestService1>();
    serviceCollection.AddSingleton<ITestService2, TestService2>();
    serviceCollection.AddSingleton<ITestService3, TestService3>();

    IServiceProvider provider = serviceCollection.BuildServiceProvider();

    var v11 = provider.GetService<ITestService1>();
    var v12 = provider.GetService<ITestService1>();
    var v21 = provider.GetService<ITestService2>();
    var v22 = provider.GetService<ITestService2>();
    var v31 = provider.GetService<ITestService3>();
    var v32= provider.GetService<ITestService3>();

    bool flag1 = object.ReferenceEquals(v11, v12);
    bool flag2 = object.ReferenceEquals(v21, v22);
    bool flag3 = object.ReferenceEquals(v31, v32);

    Console.WriteLine(flag1);
    Console.WriteLine(flag2);
    Console.WriteLine(flag3);
}
{
    IServiceCollection serviceCollection = new ServiceCollection();


    serviceCollection.AddTestService1()
        .AddTestService2()
        .AddTestService3();

    IServiceProvider provider = serviceCollection.BuildServiceProvider();

    var v11 = provider.GetService<ITestService1>();
    var v12 = provider.GetService<ITestService1>();
    var v21 = provider.GetService<ITestService2>();
    var v22 = provider.GetService<ITestService2>();
    var v31 = provider.GetService<ITestService3>();
    var v32 = provider.GetService<ITestService3>();

    bool flag1 = object.ReferenceEquals(v11, v12);
    bool flag2 = object.ReferenceEquals(v21, v22);
    bool flag3 = object.ReferenceEquals(v31, v32);

    Console.WriteLine(flag1);
    Console.WriteLine(flag2);
    Console.WriteLine(flag3);
}



Console.ReadLine();
