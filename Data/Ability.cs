using Newtonsoft.Json;

namespace ServerSideProject.Data
{
    public class Ability
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        public Ability() { }

        public Ability(string name)
        {
            Name = name;
        }
    }
}
