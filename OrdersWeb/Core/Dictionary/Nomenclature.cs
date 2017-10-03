using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrdersWeb.Model
{
    public class Nomenclature : AbstartDictionaryObject
    {
       
        [Required]
        public int NomenclatureCategoryId { get; set; }
        public NomenclatureCategory NomenclatureCategory { get; set; }
    }
}
