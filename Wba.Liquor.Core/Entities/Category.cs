namespace Wba.Liquor.Core.Entities
{
    public class Category : BaseEntity
    {
        //many
        //navigation property
        public ICollection<Booze> Boozes { get; set; }
    }
}