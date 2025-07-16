using Newtonsoft.Json;
using SplitBuddies.App.Models;

using System.Collections.Generic;
using System.IO;

namespace SplitBuddies.Services
{
    public class DataService
    {
        private static DataService _instance;
        public static DataService Instance => _instance ?? (_instance = new DataService());

        private const string UsersFile = "users.json";
        private const string GroupsFile = "groups.json";
        private const string ExpensesFile = "expenses.json";

        public List<User> Users { get; private set; }
        public List<Group> Groups { get; private set; }
        public List<Expense> Expenses { get; private set; }

        private DataService()
        {
            Users = Load<User>(UsersFile);
            Groups = Load<Group>(GroupsFile);
            Expenses = Load<Expense>(ExpensesFile);
        }

        public void SaveChanges()
        {
            Save(UsersFile, Users);
            Save(GroupsFile, Groups);
            Save(ExpensesFile, Expenses);
        }

        private static List<T> Load<T>(string file)
        {
            if (!File.Exists(file)) return new List<T>();
            var json = File.ReadAllText(file);
            return JsonConvert.DeserializeObject<List<T>>(json) ?? new List<T>();
        }

        private static void Save<T>(string file, List<T> data)
        {
            var json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(file, json);
        }
    }
}