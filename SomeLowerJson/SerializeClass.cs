using Newtonsoft.Json;

namespace SomeLowerJson
{
    public class SerializeClass
    {
        public string Serialize()
            => JsonConvert.SerializeObject(new[] { 1, 2, 3 });
    }
}
