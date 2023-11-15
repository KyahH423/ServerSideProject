using Newtonsoft.Json;

namespace ServerSideProject.Data
{
    public class SpritesMeta
    {
        [JsonProperty("front_default")]
        public string fd { get; set; }

        public Type Type { get; set; }
        
        public SpritesMeta() { }

        public override string ToString()
        {
            return fd.ToString();
        }

    }
}
