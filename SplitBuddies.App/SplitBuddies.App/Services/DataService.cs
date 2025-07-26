// Archivo: Services/DataService.cs
using Newtonsoft.Json;
using SplitBuddies.App.Models;

using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SplitBuddies.App.Services
{
    public class DataService
    {
        private static DataService _instance;
        public static DataService Instance => _instance ?? (_instance = new DataService());

        private const string DataFolder = "Data";
        private const string UsersFile = "users.json";
        private const string GroupsFile = "groups.json";
        private const string ExpensesFile = "expenses.json";

        public List<User> Users { get; private set; }
        public List<Group> Groups { get; private set; }
        public List<Expense> Expenses { get; private set; }

        private DataService()
        {
            if (!Directory.Exists(DataFolder)) Directory.CreateDirectory(DataFolder);
            Users = Load<User>(Path.Combine(DataFolder, UsersFile));
            Groups = Load<Group>(Path.Combine(DataFolder, GroupsFile));
            Expenses = Load<Expense>(Path.Combine(DataFolder, ExpensesFile));
        }

        public void SaveChanges()
        {
            Save(Path.Combine(DataFolder, UsersFile), Users);
            Save(Path.Combine(DataFolder, GroupsFile), Groups);
            Save(Path.Combine(DataFolder, ExpensesFile), Expenses);
        }

        private List<T> Load<T>(string filePath)
        {
            if (!File.Exists(filePath)) return new List<T>();
            try
            {
                var json = File.ReadAllText(filePath);
                if (string.IsNullOrWhiteSpace(json)) return new List<T>();
                return JsonConvert.DeserializeObject<List<T>>(json) ?? new List<T>();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show($"Error cargando {filePath}: {ex.Message}");
                return new List<T>();
            }
        }

        private void Save<T>(string filePath, List<T> data)
        {
            try
            {
                var json = JsonConvert.SerializeObject(data, Formatting.Indented);
                File.WriteAllText(filePath, json);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show($"Error guardando en {filePath}: {ex.Message}");
            }
        }
    }
}