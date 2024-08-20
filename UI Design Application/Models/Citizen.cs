using System.Net;

namespace UI_Design_Application.Models
{
    public class Citizen
    {
            public int Id { get; set; }
            public string? Name { get; set; }
            public string? NID { get; set; }
            public Address Address { get; set; }
            public string PhoneNumer { get; set; }
            
            public DateTime? BirthDate { get; set; }

            public string Profession { get; set; }
        
    }
}
