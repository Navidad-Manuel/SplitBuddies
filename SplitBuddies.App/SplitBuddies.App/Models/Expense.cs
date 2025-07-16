using System;
using System.Collections.Generic;
namespace SplitBuddies.App.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public int PayerId { get; set; }
        public List<int> ParticipantIds { get; set; } = new List<int>();
    }
}