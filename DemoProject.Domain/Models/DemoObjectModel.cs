using DemoProject.Domain.Models.Entity;

namespace DemoProject.Domain.Models;

public class DemoObjectModel : Entity<int>
{
    public string Name { get; private set; }

    public DemoObjectModel()
    {
    }

    public DemoObjectModel(string name, int id)
    {
        Name = name;
        Id = id;
    }
}