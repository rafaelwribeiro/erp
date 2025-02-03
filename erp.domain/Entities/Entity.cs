namespace erp.domain.Entities;

public abstract class Entity
{
    public int Id { get; set; }

    private DateTime _createdAt;
    private DateTime _updatedAt;

    public DateTime CreatedAt
    {
        get => _createdAt;
        set => _createdAt = value == default ? DateTime.UtcNow : value;
    }

    public DateTime UpdatedAt
    {
        get => _updatedAt;
        set => _updatedAt = DateTime.UtcNow;
    }

    public Entity()
    {
        _createdAt = DateTime.UtcNow;
        _updatedAt = DateTime.UtcNow;
    }
}
