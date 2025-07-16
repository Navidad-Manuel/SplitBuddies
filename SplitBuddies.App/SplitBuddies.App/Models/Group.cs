
using System.Collections.Generic;

namespace SplitBuddies.App.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<int> MemberIds { get; set; } = new List<int>();

        // Para que se vea bien en los ComboBox
        public override string ToString() => Name;
    }
}
