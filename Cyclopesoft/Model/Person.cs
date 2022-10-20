using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cyclopesoft.Model
{
    [Table("Person", Schema = "db")]
    public class Person
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string direction { get; set; }
    
    }
}
