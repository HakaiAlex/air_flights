namespace Domain.Common;

public abstract class BaseEntity<TEntityId>(TEntityId entityId)
    where TEntityId : struct
{
    public virtual TEntityId EntityId { get; protected set; } = entityId;
}
