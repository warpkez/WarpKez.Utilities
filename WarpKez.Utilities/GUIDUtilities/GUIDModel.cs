using Newtonsoft.Json;

namespace WarpKez.Utilities.GUIDUtilities
{
    public class GUIDModel
    {
        [JsonProperty("id")]
        public int Id { get; set; } = 0;
        public Guid GUID;
        public string ShortURL = string.Empty;
    }
}
