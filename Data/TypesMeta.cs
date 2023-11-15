using Newtonsoft.Json;

namespace ServerSideProject.Data
{
    public class TypesMeta
    {

        [JsonProperty("slot")]
        public int Slot { get; set; }


        [JsonProperty("type")]
        public Type Type { get; set; }

        public TypesMeta() { }
        
    }
}
