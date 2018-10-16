using System;
using System.Reflection;

namespace SomeAppDomain
{
    [Serializable]
    public class MyAppDomain : MarshalByRefObject
    {
        public void DoSomethingIndependantOfMain()
        {
            var assembly = Assembly.LoadFrom("C:\\Users\\Herec\\Documents\\Visual Studio 2017\\Projects\\AssemblyRedirects\\SomeThingMyAppDomainLoads\\bin\\Debug\\net461\\SomeThingMyAppDomainLoads.dll");
            var serializerType = assembly.GetTypes()[0];
            var serialize = Activator.CreateInstance(serializerType);
            serializerType.GetMethod("Serialize").Invoke(serialize, new object[] { }); // This is a MissingMethodException at runtime, 
        }
    }
}
