using IocCode.IServices;
using SimpleIoc.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocCode.Services
{
    public class TestService1 : ITestService1
    {

        public void Action()
        {
            Console.WriteLine($"TestService1 action");
        }
    }

    public class TestService2: ITestService2
    {
        private ITestService1 _TestService1;
        public TestService2(ITestService1 service1)
        {
            _TestService1 = service1;
        }
        public void Action()
        {
            Console.WriteLine($"TestService2 action");
        }
    }

    public class TestService3 : ITestService3
    {

        public ITestService1 _TestService1;
        [FieldInjection]
        public ITestService1 _TestServiceFieldInjection;

        public ITestService2 _TestService2 { get; set; }

        [PropertyInjection]
        public ITestService2 _TestServicePropertyInjection { get; set; }



        private ITestService2 _TestServiceMethoInjection;
        private ITestService2 _TestServiceNoMethoInjection;

        public void Action()
        {
            Console.WriteLine($"TestService3 action");
        }

        [MethodInjection]
        public void MethodInjection(ITestService2 service2)
        {
            _TestServiceMethoInjection = service2;
        }

        public void MethodInjectionNo(ITestService2 service2No)
        {
            _TestServiceNoMethoInjection = service2No;
        }
    }
}

