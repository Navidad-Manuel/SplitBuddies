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

        
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("passwordHash")]
        public string PasswordHash { get; set; }

        public override string ToString() => Name;
    }
}