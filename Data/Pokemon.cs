using Newtonsoft.Json;

namespace ServerSideProject.Data
{
    public class Pokemon
    {
        [JsonProperty("id")]
        public int Id { get; set; }


        [JsonProperty("name")]
        public string Name { get; set; }


        [JsonProperty("sprites")]
        public SpritesMeta SpriteURL { get; set; }

        [JsonProperty("abilities")]
        public List<AbilityMeta> Abilities { get; set; }

        [JsonProperty("moves")]
        public List<MoveMeta> Moves { get; set; }

        [JsonProperty("types")]
        public List<TypesMeta> Types { get; set; }


        [JsonProperty("stats")]
        public List<StatsMeta> Stats { get; set; }


        [JsonProperty("weight")]
        public int Weight { get; set; }


        [JsonProperty("height")]


        public int Height { get; set; }

    }
}
