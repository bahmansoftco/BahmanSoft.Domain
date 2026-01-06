namespace BahmanSoft.Doamin.Common
{
    public interface IAuditedEntity<TCreatorId, TCreatorEntity>
    {
        DateTime CreationTime { get; set; }
        TCreatorId CreatorId { get; set; }
        TCreatorEntity Creator { get; set; }
    }
}
