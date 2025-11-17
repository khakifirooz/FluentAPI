namespace FluentAPI;

public interface IEntityConfig
{
    public Entity entity { get; set; }
    IEntityConfig Init();
    IEntityConfig AddTitle(string title);
    IEntityConfig AddValue(int value);
    Entity GetData();
}
