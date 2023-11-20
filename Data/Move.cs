using Newtonsoft.Json;

namespace ServerSideProject.Data
{
    public class Move
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        public Move() { }

        public Move(string name)
        {
            Name = name;
        }
    }
}
