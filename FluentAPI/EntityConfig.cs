namespace FluentAPI;

public class EntityConfig : IEntityConfig
{
    public Entity entity { get; set; }
    public EntityConfig()
    {
        entity = new Entity();
    }
    public IEntityConfig Init()
    {
        entity = new Entity();
        return this;
    }
    public IEntityConfig AddTitle(string title)
    {
        entity.Title = title;
        return this;
    }
    public IEntityConfig AddValue(int value)
    {
        entity.Value = value;
        return this;
    }
    public Entity GetData()
    {
        return entity;
    }
}