using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cyclopesoft.Model
{

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
