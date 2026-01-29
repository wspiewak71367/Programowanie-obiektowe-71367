using System.Collections.Generic;
using System.IO;
using System.Linq;

public class TxtContactRepository
{
    private string path = "contacts.txt";

    public void Save(List<ContactManager.Contact> contacts)
    {
        var lines = contacts.Select(c => $"{c.Id};{c.Name};{c.Email}");
        File.WriteAllLines(path, lines); 
    }

    public List<ContactManager.Contact> Load()
    {
        if (!File.Exists(path)) return new List<ContactManager.Contact>(); 
        return File.ReadAllLines(path).Select(line => {
            var parts = line.Split(';');

            return new ContactManager.Contact
            {
                Id = int.Parse(parts[0]), 
                Name = parts[5],          
                Email = parts[1]         
            };
        }).ToList();
    }
}