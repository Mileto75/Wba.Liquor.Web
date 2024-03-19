using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wba.Liquor.Core.Entities
{
    public class Booze : BaseEntity
    {
        public int Volume { get; set; }
        public float AlcoholPercentage { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        //one
        //navigation property
        //one to many category
        public Category Category { get; set; }
        //unshadowed foreign key property
        public int CategoryId { get; set; }
        //many to many properties
        public ICollection<Property> Properties { get; set; }
        //one to many Brands
        public Brand Brand { get; set; }
        public int BrandId { get; set; }
    }
}
