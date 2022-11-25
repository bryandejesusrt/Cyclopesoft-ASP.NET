using System;

namespace Cyclopesoft.ServicesLayer.Models
{
    public class ClientModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime EnrollomentDate { get; set; }
        public DateTime EnrollomentDateDisplay { get; set; }
    }
}
