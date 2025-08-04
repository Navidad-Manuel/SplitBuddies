
using Newtonsoft.Json;
using System.Collections.Generic;

namespace SplitBuddies.App.Models
{
    public class Group
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("imagePath")]
        public string ImagePath { get; set; }
        [JsonProperty("memberIds")]
        public List<int> MemberIds { get; set; } = new List<int>();
        public override string ToString() => Name;
    }
}