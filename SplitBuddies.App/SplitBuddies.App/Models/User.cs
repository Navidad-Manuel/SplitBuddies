// Archivo: Models/User.cs
using Newtonsoft.Json;

namespace SplitBuddies.App.Models
{
    public class User
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        public override string ToString() => Name;
    }
}