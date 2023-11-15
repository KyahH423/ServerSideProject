using Newtonsoft.Json;

namespace ServerSideProject.Data
{
    public class Stat
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        public Stat() { }

        public Stat(string name)
        {
            Name = name;
        }
    }
}
