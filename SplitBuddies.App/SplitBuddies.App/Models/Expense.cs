// Archivo: Models/Expense.cs
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SplitBuddies.App.Models
{
    public class Expense
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("groupId")]
        public int GroupId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("amount")]
        public decimal Amount { get; set; }
        [JsonProperty("date")]
        public DateTime Date { get; set; }
        [JsonProperty("payerId")]
        public int PayerId { get; set; }
        [JsonProperty("participantIds")]
        public List<int> ParticipantIds { get; set; } = new List<int>();
        [JsonProperty("link")]
        public string Link { get; set; }
    }
}