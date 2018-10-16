using Newtonsoft.Json;
using SomeAppDomain;
using System;

namespace AssemblyRedirects
{
    class Program
    {
        static void Main(string[] args)
        {
            var json = JsonConvert.SerializeObject(new[] { 1, 2, 3 });
            //var moreJson = new SomeLowerJson.SerializeClass().Serialize();

            var a = AppDomain.CreateDomain("NewAppDomain");
            var instance = (MyAppDomain)a.CreateInstanceAndUnwrap(typeof(MyAppDomain).Assembly.FullName, typeof(MyAppDomain).FullName);
            instance.DoSomethingIndependantOfMain();
        }
    }
}
