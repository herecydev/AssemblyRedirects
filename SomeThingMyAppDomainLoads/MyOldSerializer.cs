using Newtonsoft.Json.Converters;

namespace SomeThingMyAppDomainLoads
{
    public class MyOldSerializer
    {
        public void Serialize()
        {
            var a = new BinaryConverter();
            a.GetSchema();
        }
    }
}
