namespace CommonGenericClasses;
public abstract class BaseEntity
{
    public Guid Id { get; set; }
    public DateTime CreationDate { get; set; }
    public byte[] ConcurrencyStamp { get; set; }=null!;
}