using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrdersWeb.Model
{
    public class Department : AbstartDictionaryObject
    {
        public List<Nomenclature> Nomenclatures { get; set; }
        public List<CommentTheme> CommentThemes { get; set; }
    }
}
