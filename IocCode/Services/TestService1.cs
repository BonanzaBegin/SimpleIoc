using IocCode.IServices;
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
        public void Action()
        {
            Console.WriteLine($"TestService2 action");
        }
    }

    public class TestService3 : ITestService3
    {
        public void Action()
        {
            Console.WriteLine($"TestService3 action");
        }
    }
}
