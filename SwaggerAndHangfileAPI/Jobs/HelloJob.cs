using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerAndHangfireAPI.Jobs
{
    public class HelloJob : IHelloJob
    {
        public void Helloprint()
        {
            Console.WriteLine("a new textmessage from class");
        }
    }
}
