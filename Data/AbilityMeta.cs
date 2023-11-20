using Newtonsoft.Json;

namespace ServerSideProject.Data
{
    public class AbilityMeta
    {
        [JsonProperty("ability")]
        public Ability Ability { get; set; }

        public AbilityMeta() { }
    }
}
