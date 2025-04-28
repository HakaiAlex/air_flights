namespace Domain.Common;

public abstract class BaseEntity<TEntityId>(TEntityId entityId)
    where TEntityId : struct
{
    public virtual TEntityId Id { get; protected set; } = entityId;
}
