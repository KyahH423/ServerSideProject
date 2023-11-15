using Newtonsoft.Json;

namespace ServerSideProject.Data
{
    public class Type
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        public Type() { }

        public Type(string name)
        {
            Name = name;
        }
    }
}
