namespace Wba.Liquor.Core.Entities
{
    public class Brand : BaseEntity
    {
        public ICollection<Booze> Boozes { get; set; }
    }
}