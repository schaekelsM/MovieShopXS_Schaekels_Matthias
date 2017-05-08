using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShopXS.Models
{
    [Table("MovieActor")]
    public class MovieActor
    {
        public int id { set; get; }
        [ForeignKey("MovieID")]
        public int MovieID { set; get; }
        [ForeignKey("PersonID")]
        public int ActorID { set; get; }

        public virtual Person Actor { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
