using Newtonsoft.Json;

namespace ServerSideProject.Data
{
    public class MoveMeta
    {
        [JsonProperty("move")]
        public Move Move { get; set; }

        public MoveMeta() { }
    }
}
