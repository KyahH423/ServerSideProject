using Newtonsoft.Json;

namespace ServerSideProject.Data
{
    public class StatsMeta
    {
        [JsonProperty("base_stat")]
        public int BaseStat { get; set; }


        [JsonProperty("stat")]
        public Stat Stat { get; set; }

        public StatsMeta() { }
    }
}
