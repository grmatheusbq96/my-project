namespace DemoProject.Domain.Models.Entity;

public abstract class Entity<Tid>
{
    public Tid Id { get; protected set; }
}