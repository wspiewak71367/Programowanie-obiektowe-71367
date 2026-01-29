using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class JsonContactRepository
{
    private string path = "contacts.json";

    public void Save(List<ContactManager.Contact> contacts)
    {
        string json = JsonSerializer.Serialize(contacts, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(path, json);
    }

    public List<ContactManager.Contact> Load()
    {
        if (!File.Exists(path)) return new List<ContactManager.Contact>();
        string json = File.ReadAllText(path);
        return JsonSerializer.Deserialize<List<ContactManager.Contact>>(json);
    }
}