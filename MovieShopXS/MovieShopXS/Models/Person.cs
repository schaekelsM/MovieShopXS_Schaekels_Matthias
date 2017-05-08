using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShopXS.Models
{
    [Table("Person")]
    public class Person
    {
        [Key]
        public int PersonID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }


        public ICollection<MovieActor> MovieActor { get; set; }
    }
}
