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

    }
}
